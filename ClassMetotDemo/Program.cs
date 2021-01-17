using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Cem";
            musteri1.Soyadi = "Eröksüz";
            musteri1.Yas = 27;
            musteri1.email = "cemeroksuz@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demiroğ";
            musteri2.Yas = 34;
            musteri2.email = "engindemirog@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Can";
            musteri3.Soyadi = "Ercan";
            musteri3.Yas = 30;
            musteri3.email = "canercan@gmail.com";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriMananger = new MusteriManager();

            musteriMananger.MusteriEkle(musteri1);
            musteriMananger.MusteriEkle(musteri2);
            musteriMananger.MusteriEkle(musteri3);

            musteriMananger.MusteriListele(musteriler);

            musteriMananger.MusteriSil(musteri3);

            

            
           


        }


    }

    

}
