using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektKolokwium
{

    public struct Lokalizacja 
    {
        private string _miasto;
        private string _panstwo;

        public string Miasto { get => _miasto; set => _miasto = value; }
        public string Panstwo { get => _panstwo; set => _panstwo = value; }

        public Lokalizacja(string miasto, string panstwo)
        {
            _miasto = miasto;
            _panstwo = panstwo;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Oferta oferta = new Oferta(new Lokalizacja("Lizbona", "Portigalia"), "Melia", "04-10-2020", "10-10-2020");
            Oferta oferta2 = new Oferta(new Lokalizacja("Lizbona", "Portigalia"), "Melia", "04-10-2020", "10-10-2020");
            Oferta oferta3 = new Oferta(new Lokalizacja("Kraków", "Polska"), "Melia", "04-10-2020", "10-10-2020");

            ListaOfert listaOfert = new ListaOfert();

            listaOfert.dodaj(oferta);
            listaOfert.dodaj(oferta2);
            listaOfert.dodaj(oferta3);


            List<Oferta> oferty = listaOfert.wyszukaj(new Lokalizacja("Lizbona", "Portigalia"));

            foreach(Oferta o in oferty)
            {
                Console.WriteLine(o.ToString());
            }

            Console.ReadKey();
        }
    }
}
