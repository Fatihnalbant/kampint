using System;

namespace kampint
{
    class Program
    {
        static void Main(string[] args)
        {   
            // type safety = tip güvenliği
            //do not repeat yourself = Kendini Tekrarlama

            string kategoriEtijketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else (dolarDun == dolarBugun);
            {
                Console.WriteLine("Değişmedi Oku");
            }


            if (sistemeGirisYapmisMi == true)
            { 
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
                                 
            Console.WriteLine(kategoriEtijketi);


        }
    }
}
