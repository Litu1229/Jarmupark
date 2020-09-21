using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jarmupark
{
    class auto
    {
        public string szin;
        public string tipus;
        public double uzemAnyag;
        public double fogyaszt;
        public double km;
        public double megtehetokm;

        public auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
            this.megtehetokm = 0;
        }
        public void Megteheto()
        {
            megtehetokm = uzemAnyag / fogyaszt * 100;
        }
        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            megtehetokm = uzemAnyag / fogyaszt * 100;
        }
        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            megtehetokm = uzemAnyag / fogyaszt * 100;
        }
        public void Allapot()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemAnyag}1");
            Console.WriteLine($"Megtehető km: {megtehetokm} km");
            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }
}

