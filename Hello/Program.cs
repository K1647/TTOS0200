using System;  //Aakkosjärjestys!
/* Eka testi ohjelma 9.1.2017 */
//Joona's demo soft
namespace Hello
{
    class Henkilo
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }
    class Testi
    {
        static void Main(string[] args)
        {
            //SayHello();
            //ShowNames();
            Lotto();
        }

        static void ShowNames()
        {
            string[] kayttajat = new string[5];
            for (int i = 0; i < kayttajat.Length; i++) {
                Console.WriteLine("Anna kayttaja: ");
                kayttajat[i] = Console.ReadLine();
            }
            Console.WriteLine("annetut nimet olivat:");
            for (int i = 0; i < kayttajat.Length; i++)
            {
                Console.WriteLine(kayttajat[i]);
            }

            Console.WriteLine("annetut nimet aakkosjarjestyksessa ovat:");
            Array.Sort(kayttajat);
            for (int i = 0; i < kayttajat.Length; i++)
            {
                Console.WriteLine(kayttajat[i]);
            }

            Console.WriteLine("Ohjelma souritettu onnistuneesti");
            Console.ReadLine();
        }
        static void SayHello()
        {
            //luodaa olio Henkilo luokasta
            Henkilo hlo = new Henkilo();
            hlo.Ika = 42;
            hlo.Nimi = "Max Mickelson";
            // tulostetaan muuttujan arvo konsolille
            Console.WriteLine("Nimi on {0} ja ikäsi on {1}", hlo.Nimi, hlo.Ika);
            // pidetään sovelluksen ajoikkuna näytöllä. Sulkeutuu, kun enter-painiketta on painettu
            Console.ReadLine();
        }

        static void Lotto()
        {
            int[] lottorivit = new int[41];
            int n;
            int x = 0;
            int y = 0;
            int i = 0;
            int toistot = 7;
            Random rand = new Random();
        
            Console.Write("Anna arvottavien rivien määrä: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i != n)
            {
                Array.Clear(lottorivit, 0, 41);
                for (y = 1; y <= toistot; y++)
                {
                    x = rand.Next(40) % 40 + 1; // arpoo luvun 1-40
                    while (lottorivit[x] != 0)
                    {
                        x = rand.Next(40) % 40 + 1;
                    }
                    lottorivit[x] = 1; // luku x arvottu
                }
                Console.WriteLine("\n\n" + (i + 1) + ". Lottorivisi ");
                for (y = 1; y <= 40; y++)
                // tulostetaan "arvotut numerot"
                {
                    // Console.Write(y + 1 + "rivi");
                    if (lottorivit[y] == 1)
                    {
                        Console.Write(y + " ");
                    }
                }
        
                i++;
            }
            Console.WriteLine("\n\nPaina lopettaaksesi [Enter].");
            Console.Read();
        }
    }
}
