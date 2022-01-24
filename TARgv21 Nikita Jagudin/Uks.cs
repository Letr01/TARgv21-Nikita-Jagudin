using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv21_Nikita_Jagudin
{
        public class Uks
        {
            public static string Color { get; set; }

            public Uks(string color = "sinine")
            {
                Color = color;
            }
            public static void NaitaInfo()
            {
                Console.WriteLine($"Mina olen uks, minu värv on {Color}");
            }
        }   
}
