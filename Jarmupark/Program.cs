using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark
{
    class Program
    {
        static void Main(string[] args)
        {
            auto lada = new auto("Piros","Lada2112",12);
            auto trabant = new auto("zöld","Trabant 1.1",15);

            lada.Tankol(20);
            trabant.Tankol(20);
           
            lada.Allapot();
            trabant.Allapot();
            Console.WriteLine("Mennyit megy a lada: ");
            int km = int.Parse(Console.ReadLine());
            lada.Megy(km);
            lada.Allapot();

            Console.WriteLine("Mennyit megy a trabant: ");
            int km2 = int.Parse(Console.ReadLine());
            trabant.Megy(km2);
            trabant.Allapot();
            Console.ReadKey();
        }
    }
}
