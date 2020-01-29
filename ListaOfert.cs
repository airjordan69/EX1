using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKolokwium
{
    public class ListaOfert
    {	
		//POLA
		private LinkedList<Oferta> _oferty;

		//METODY AKCESOROWE
		public LinkedList<Oferta> Oferty
		{
			get { return _oferty; }
			set { _oferty = value; }
		}

		public ListaOfert()
		{
			_oferty = new LinkedList<Oferta>();
		}

		public void dodaj(Oferta o)
		{
			_oferty.AddLast(o);
		}

		public void zmienHotel(int nrOferty, string hotel)
		{
			_oferty.Where(x => x.NrOferty == nrOferty).First().Hotel = hotel;
		}

		public List<Oferta> wyszukaj(Lokalizacja l)
		{
			return _oferty.Where(x => x.Lokalizacja.Equals(l)).ToList();
		}
	}
}
