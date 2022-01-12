using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
     public abstract class Sekil
    {
        string sekilad;

        public void SekilYaz()
        {
            Console.WriteLine("şekil yaz:"+sekilad);
        }
        abstract public void CevreHesapla();


        abstract public void AlanHesapla();

    }
}
