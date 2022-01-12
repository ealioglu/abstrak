using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Dortgen:
    {
        public decimal boy;
        public decimal en;

        public override void AlanHesapla()
        {
            Console.WriteLine("daörtgenin alanı:{0}",en*boy);
        }

    }
}
