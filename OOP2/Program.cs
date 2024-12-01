// See https://aka.ms/new-console-template for more information
using OOP2;


//Musteri musteri1= new Musteri();
//musteri1.Adi = "Engin";


GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "564164";
musteri1.Adi = "Seda";
musteri1.Soyadi = "Tuncay";
musteri1.TcNo = "1254698365";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo ="6454";
musteri2.SirketAdi= "Kodlama io";
musteri2.VergiNo = "32115544";

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

CustomerManager customerManager = new CustomerManager();
customerManager.Ekle(musteri4);


