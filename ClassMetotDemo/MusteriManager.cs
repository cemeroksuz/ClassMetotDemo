using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Adlı Müşteri Sisteme Eklendi\n");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Adlı Müşteri Sistemden Çıkartıldı\n");


        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id + "\nMüşteri Adı: " + musteri.Adi + "\nMüşteri Soyadı: " + musteri.Soyadi + "\nMüşteri Yaşı: " + musteri.Yas + "\nMüşteri Mail: " + musteri.email);
                Console.WriteLine("--------------------------------------------");
                   
            }
        }
    }
}
