using System;

namespace BaslangicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double ornekSayi = 5.2;
            bool sistemKontrol = false;

            if (sistemKontrol == true)
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }
        }
    }
}
