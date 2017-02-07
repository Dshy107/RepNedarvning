using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepNedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            DieselBil dieselbil = new DieselBil(200000, 2002, "Fiat", "xx99999", 20);
            List<DieselBil> DBilliste = new List<DieselBil>();
            DBilliste.Add(dieselbil);
            DBilliste.Add(new DieselBil( 260000, 2002, "Obel", "ZZ12345", 15));
            DBilliste.Add(new DieselBil( 340000, 2005, "Audi", "ZX22345", 17));
            DBilliste.Add(new DieselBil( 220000, 2010, "VW", "XZ32345", 20) );
            DBilliste.Add(new DieselBil( 500000, 2012, "BMW", "YY42345", 22));


            foreach (var bil in DBilliste)
            {
                Console.WriteLine(bil.ToString(), bil.HalfYear());

            }
            Console.ReadLine();
        }
    }
}
