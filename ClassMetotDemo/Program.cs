using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
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

            MusteriManager musterimanage = new MusteriManager();
            musterimanage.Ekle(musteri1);
            musterimanage.Sil(musteri2);

            musterimanage.Listele(musteri1);



        }
    }
}