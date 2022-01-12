using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrack
{
    class Program
    {
        static void Main(string[] args)
        {
            //temelSinif t1 = new temelSinif();

            Musteri m1 = new Musteri();
            m1.kayitTarihleri = DateTime.Now;
            m1.test();
            Console.ReadLine();


        }
    }
}
