using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enginDemirogDay3
{
    internal class SepetManager
    {
        // naming convention 
        // syntax - yazım şekilleri
        // encapsulation
        public void Ekle(Product product )
        {
            Console.WriteLine("Sepete Eklendi:" + product.Adi);
        }

        public void Ekle2 (string urunAdi , string Aciklama , double Fiyati , int StokAdedi)
        {
            Console.WriteLine("Sepete Eklendi:" + urunAdi +" "+ Aciklama +" "+ Fiyati +""+ StokAdedi );

        }
    }
}
