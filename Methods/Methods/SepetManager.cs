using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Product product)
        {

            Console.WriteLine("Sepete eklendi" + product.Adi);
        
        }
        public void Ekle2(string productAdi, string aciklama,double fiyat)
        {
            Console.WriteLine("Sepete eklendi" + productAdi);


        }
    }
}
