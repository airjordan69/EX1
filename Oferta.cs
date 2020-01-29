using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKolokwium
{
    public class Oferta
    {

		//POLA PRYWATNE
		private int _nrOferty;
		private string _hotel;
		private DateTime _terminOd;
		private DateTime _terminDo;
		private int _liczbaDni;
		private Lokalizacja _lokalizacja;

		private static int licznikOfert = 0;

		//METODY AKCESOROWE
		public Lokalizacja Lokalizacja
		{
			get { return _lokalizacja; }
			set { _lokalizacja = value; }
		}


		public int LiczbaDni
		{
			get { return _liczbaDni; }
			set { _liczbaDni = value; }
		}



		public DateTime TerminDo
		{
			get { return _terminDo; }
			set { _terminDo = value; }
		}


		public DateTime TerminOd
		{
			get { return _terminOd; }
			set { _terminOd = value; }
		}


		public string Hotel
		{
			get { return _hotel; }
			set { _hotel = value; }
		}


		public int NrOferty
		{
			get { return _nrOferty; }
			set { _nrOferty = value; }
		}

		//KONSTRUKTORY
		public Oferta(Lokalizacja lokalizacja, string hotel, string terminOd, string terminDo)
		{
			_terminOd = DateTime.Parse(terminOd);
			_terminDo = DateTime.Parse(terminDo);
			if (_terminDo < _terminOd)
				throw new BladDatyException("TerminOd nie może być późniejszy niż TerminDo!");
			_nrOferty = ++licznikOfert;
			_lokalizacja = lokalizacja;
			_hotel = hotel;
			_liczbaDni = WyznaczLiczbeDni(_terminOd, _terminDo);
		}

		public Oferta(Lokalizacja lokalizacja, string hotel, string terminOd, int liczbaDni)
		{
			if(liczbaDni < 0)
				throw new BladDatyException("Liczba dni nie może być ujemna!");
			_nrOferty = ++licznikOfert;
			_lokalizacja = lokalizacja;
			_hotel = hotel;
			_terminOd = DateTime.Parse(terminOd);
			_liczbaDni = liczbaDni;
			_terminDo = WyznaczDataDo(_terminOd, _liczbaDni);
		}


		//METODY PRYWATNE
		private int WyznaczLiczbeDni(DateTime a, DateTime b)
		{
			return b.DayOfYear - a.DayOfYear;
		}

		private DateTime WyznaczDataDo(DateTime a, int b)
		{
			return a.AddDays(b);
		}

		//METODY PUBLICZNE
		public override string ToString()
		{
			return $"{NrOferty} {Hotel} {TerminOd.ToString("dd-MM-yyyy")} {TerminDo.ToString("dd-MM-yyyy")}";
		}
	}
}
