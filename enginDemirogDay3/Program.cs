using enginDemirogDay3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enginDemirogDay3Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "etek";
            double fiyati = 300;
            string aciklama = "siyah mini";

            Product product1 = new Product();
            product1.Adi = "Etek";
            product1.Fiyati = 300;
            product1.Aciklama = "Mini";

            Product product2 = new Product();
            product2.Adi = "Kazak";
            product2.Fiyati = 450;
            product2.Aciklama = "Triko";



            Product[] products = new Product[] {
                product1, product2  
            };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------");
            }

           

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(product1);

            sepetManager.Ekle2("saat", "altın", 1240 , 2);

            
            

        }
    }
}
