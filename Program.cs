using System;

namespace Sayı_Ort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı girilecek: ");
            int adet = int.Parse(Console.ReadLine());
            double toplam = 0;
            int ort = 0;
            double sayac = 0;
            double say = 0;
            say = say + 1;



            for (int i = 1; i <= adet; i++)
            {
                Console.Write(say + ". Sayı girin: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi > 50)
                {
                    toplam = sayi + toplam;
                    sayac = sayac + 1;
                }

            }
            double ortalama = toplam / sayac;

            Console.WriteLine("50'den Büyük sayı adedi " + sayac);
            if (sayac > 0)
            {
                Console.WriteLine("Girilen sayılardan 50'den büyük sayıların ortalaması: " + ortalama);
            }
            
        }
    }
}
