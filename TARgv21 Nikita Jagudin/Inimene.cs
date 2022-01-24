using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv21_Nikita_Jagudin
{
    public class Inimene
    {
        private string nimi;

        public Hoone hoone { get; set; }
        public Inimene(string nimi)
        {
            this.nimi = nimi;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen inimene, minu nimi on {nimi}");
            Console.WriteLine("Hoone info:");
            hoone.NaitaInfo();
            Console.WriteLine("Data of door:");
            Uks.NaitaInfo();
        }
    }
}
