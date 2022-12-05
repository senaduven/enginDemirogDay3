using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();

            //dortIslem.Topla(2, 3);

            Console.WriteLine("Toplamak istediğiniz iki sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            dortIslem.Topla(sayi1, sayi2);


            Console.ReadLine();

        }
    }
}
