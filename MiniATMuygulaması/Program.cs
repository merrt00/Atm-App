using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATMuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya soracağız nasıl bir işlem yapmak istediğini 
            // 1- Bakiye Görüntüleme
            // 2- Para Çekme
            // 3- Para Yatırma
            // q ya basarsa çıkış yaptıracağız.

            int bakiye = 1000;

            Console.WriteLine("Hoşgeldiniz! Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1- Bakiye Görüntüleme   2- Para Çekme   3- Para Yatırma   4- Çıkış için q'ya basınız. ");
            string secim = Console.ReadLine();


            if(secim == "1")
            {
                Console.WriteLine("Şu anki bakiyeniz= " + bakiye);
                Console.ReadLine();

            }

            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutar nedir?");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                
               if (bakiye >= cekilecek_tutar)
                {
                    Console.WriteLine("İşleminiz onaylandı... Kalan Tutar: " + (bakiye - cekilecek_tutar));
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Bakiye Yetersiz!");
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Güncel Bakiyeniz: " + (bakiye + yatirilacak_tutar));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor...");
                Console.WriteLine("Çıkış Yapıldı. İYİ GÜNLER...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz: ");
                Console.ReadLine();

            }
        }
    }
}
