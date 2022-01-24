using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv21_Nikita_Jagudin
{
    public class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
        public Hoone_materjal Hoone_materjal { get; set; }
        public Uks GetUks()
        {
            return uks;
        }


        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }
        public Hoone(int pindala, Hoone_materjal hoone_Materjal)
        {
            Pindala= pindala;
            Hoone_materjal = hoone_Materjal;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen {Hoone_materjal}, minu pindala on {Pindala} m2");
            if (Pindala > 0 && Pindala < 51)
            {
                Console.WriteLine("Mina olen väike maja");
            }
            else if (Pindala > 50 && Pindala < 101)
            {
                Console.WriteLine("Mina olen keskmine maja");
            }
            else if (Pindala >100 && Pindala < 151)
            {
                Console.WriteLine("Mina olen suur maja");
            }
            else if (Pindala > 150)
            {
                Console.WriteLine("Mina olen liiga suur maja");
            }
        }
        public class EraMaja : Hoone
        {
            public EraMaja(int pindala = 50) : base(pindala)
            {
            }
            
        }
        public class KorteriteMaja : Hoone
        {
            public KorteriteMaja(int korter = 27) : base(korter)
            {
                if (korter > 0 && korter < 5)
                {
                    Console.WriteLine("See on esimene korrus");
                }
                else if (korter > 4 && korter < 9)
                {
                    Console.WriteLine("See on teine korrus");
                }
                else if (korter > 8 && korter < 13)
                {
                    Console.WriteLine("See on kolmandas korrus");
                }
                else if (korter > 12 && korter < 17)
                {
                    Console.WriteLine("See on neljas korrus");
                }
                else if (korter > 16 && korter < 21)
                {
                    Console.WriteLine("See on viies korrus");
                }
                else if (korter > 20 && korter < 25)
                {
                    Console.WriteLine("See on kuues korrus");
                }
                else if (korter > 24 && korter < 29)
                {
                    Console.WriteLine("See on seitsmes korrus");
                }
                else if (korter > 28 && korter < 33)
                {
                    Console.WriteLine("See on kaheksas korrus");
                }
                else if (korter > 32 && korter < 37)
                {
                    Console.WriteLine("See on üheksas korrus");
                }
            }
        }
    }
}