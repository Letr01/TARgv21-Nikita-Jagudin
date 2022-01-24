using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv21_Nikita_Jagudin
{
    static class Program
    {
        static void Main(string[] args)
        {
            Hoone hoone = new Hoone(135, Hoone_materjal.Kivimaja);
            hoone.NaitaInfo();
            Hoone.EraMaja majake = new Hoone.EraMaja();
            Inimene mees = new Inimene("Juku");
            var Uks = new Uks("must");
            mees.hoone = majake;
            mees.NaitaInfo();
            Hoone KorteriteMaja = new Hoone.KorteriteMaja();
            KorteriteMaja.NaitaInfo();
        }
    }
}
