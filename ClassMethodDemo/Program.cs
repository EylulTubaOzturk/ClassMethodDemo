using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");

            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Adi = "Eylül";
            musteri1.Soyad = "Öztürk";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "Ahmet";
            musteri2.Soyad = "Güçlü";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("Müşteri Listesi");

            foreach (var listele in musteriler)
            {

                Console.WriteLine("Müşteri Adı : " + listele.Adi);

            }

            Console.WriteLine("-----------------------------");
            MusteriManager islemler = new MusteriManager();

            islemler.Ekle(musteri1);
            islemler.Ekle(musteri2);

            islemler.Sil(musteri1);
            islemler.Sil(musteri2);

            islemler.Duzenle(musteri1);
            islemler.Duzenle(musteri2);



            Console.WriteLine("İşlem Bitti");
        }
    }

    class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }


    }
    class MusteriManager
    {
        public void Ekle(Musteri musterim)
        {
            Console.WriteLine("ID: " + musterim.Id + " Adı: " + musterim.Adi + " Soyad : " + musterim.Soyad + ": " + " Müşteri eklendi");
        }

        public void Sil(Musteri musterim)
        {
            Console.WriteLine("ID: " + musterim.Id + " Adı: " + musterim.Adi + " Soyad : " + musterim.Soyad + ": " + " Müşteri silindi");
        }

        public void Duzenle(Musteri musterim)
        {
            Console.WriteLine("ID: " + musterim.Id + " Ad : " + musterim.Adi + " Soyad : " + musterim.Soyad + " : " + " Müşteri düzenlendi");
        }



    }
}