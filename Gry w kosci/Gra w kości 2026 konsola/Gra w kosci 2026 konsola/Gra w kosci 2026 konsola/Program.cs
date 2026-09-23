using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Gra_w_kosci_2026_konsola
{


    internal class Kosc
    {

        public static int LiczbaInstancji = 0;

        public string[] Obrazy = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };

        public int LiczbaOczek;

        public int IdentyfikatorPliku;

        public bool CzyDostepna = true;


        public Kosc(int liczbaOczek)
        {
            if (liczbaOczek < 1 || liczbaOczek > 6) {
                liczbaOczek = 0;
            }
            LiczbaOczek = liczbaOczek;
            IdentyfikatorPliku = liczbaOczek;

            LiczbaInstancji++;

        }

        public Kosc()
        {
            Random random = new Random();

            LiczbaOczek = random.Next(1, 7);
            IdentyfikatorPliku = LiczbaOczek;
            CzyDostepna = true;

            LiczbaInstancji++;

        }

     

        public void Rzut()
        {
            if (CzyDostepna)
            {
                Random random = new Random();

                LiczbaOczek = random.Next(1, 7);
                IdentyfikatorPliku = LiczbaOczek;
            }
        }



        public void Blokuj()
        {
            CzyDostepna = false;
        }

        public string ZwrocWartosc()
        {
            switch (LiczbaOczek)
            {
              
                case 1: return "jeden"; 
                case 2: return "dwa"; 
                case 3: return "trzy"; 
                case 4: return "cztery"; 
                case 5: return "pięć";
                case 6: return "sześć"; 
                default: return "Błąd";



            }

        }


        static void Main(string[] args)
        {

          


            Console.Write("Podaj wartość pierwszej kości: ");
            int podanaWartosc = Convert.ToInt32(Console.ReadLine());

            Kosc Obiekt1 = new Kosc(podanaWartosc);

            Console.WriteLine();
            Console.WriteLine("Pierwsza kość:");
            Console.WriteLine("Liczba instancji: " + LiczbaInstancji);
            Console.WriteLine("Liczba oczek: " + Obiekt1.LiczbaOczek);
            Console.WriteLine("Liczba oczek słownie: " + Obiekt1.ZwrocWartosc());
            Console.WriteLine("Plik obrazu: " + Obiekt1.Obrazy[Obiekt1.IdentyfikatorPliku]);


            Kosc Obiekt2 = new Kosc();

            Console.WriteLine();
            Console.WriteLine("Druga kość:");
            Console.WriteLine("Liczba instancji: " + LiczbaInstancji);
            Console.WriteLine("Liczba oczek: " + Obiekt2.LiczbaOczek);
            Console.WriteLine("Liczba oczek słownie: " + Obiekt2.ZwrocWartosc());
            Console.WriteLine("Plik obrazu: " + Obiekt2.Obrazy[Obiekt2.IdentyfikatorPliku]);

            Console.ReadKey();



        }
        }

       
    }

