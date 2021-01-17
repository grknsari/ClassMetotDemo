using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" Eklenen Müşteri : " + musteri.MusteriAdi + musteri.MusteriSoyad);
        }


        public void Sil(Musteri musteriSil)
        {
            Console.WriteLine(" Silinen Müşteri : " + musteriSil.MusteriAdi + musteriSil.MusteriSoyad);
        }

        public void Listele(Musteri musteriListe)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 12345;
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyad = "Karaca";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 123456;
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyad = "Satar";
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);

                Console.WriteLine(musteri.MusteriAdi);

                Console.WriteLine(musteri.MusteriSoyad);


                Console.WriteLine("--------------");



            }
        }
    }
}
