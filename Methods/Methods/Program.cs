using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Aciklama = "Elmasi";
            product1.fiyati = 15;

           Product product2 = new Product();
            product2.Adi = "Kapruz";
            product2.Aciklama = "karrrpuız";
            product2.fiyati = 15;

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.fiyati);
                Console.WriteLine(product.Aciklama);
            }
            Console.WriteLine("--------Methodlar------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product1);

            sepetManager.Ekle2("Armut", "Yesilarmut", 12);
            sepetManager.Ekle2("Armut", "Yesilarmut", 12);
            sepetManager.Ekle2("Armut", "Yesilarmut", 12);



        }
    }
}
