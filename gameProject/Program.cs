using System;

namespace gameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new EskiOyuncu()
            {
                OyuncuAdi = "Özge",
                OyuncuSoyadi = "Özbilgin",
                DogumYılı = 1995,
                TcNo = "12345678910",
                UyelikYili = 1
            };

            OyunYoneticisi oyunYoneticisi = new OyunYoneticisi();
            oyunYoneticisi.Add(new Oyun() { OyunAdı = "Oyun1", OyunTuru = "Aksiyon", OyunFiyati = 30, OyunuYapan = "Melek Özbilgin" });
            oyunYoneticisi.Add(new Oyun() { OyunAdı = "oOyun2 ", OyunTuru = "Aksiyon", OyunFiyati = 40, OyunuYapan = "Melek Özbilgin" });

            while (true)
            {
                Console.WriteLine("---------MENU----------");
                Console.WriteLine("1- OYuncu Ekle" +  " " + "2- Oyuncu Sil" + "  " + "3- Kullancıları Listele" + "  " + "4- Kampanyaları Listele" + "  " + "5-Oyun Ekle" + "  " + "6-Oyun Sil" + "  " + "7-Çıkış");
                Console.WriteLine("-----------------------");
                int seçim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (seçim == 1)
                {
                    Console.WriteLine("Eklemek istedğiniz kullanıcıları girin");
                    Console.WriteLine("Tc No");
                    string TcNo = Console.ReadLine();
                    Console.WriteLine("Ad:");
                    string oyuncuadi = Console.ReadLine();
                    string oyuncusoyadi = Console.ReadLine();
                    Console.WriteLine("Dogum Yılı");
                    int dogumyili = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("kaç yıl sözleşme istersiniz ?");
                    int sozlemeyili = Convert.ToInt32(Console.ReadLine());
                    oyunYoneticisi.Add(new YeniOyuncu() { TcNo = TcNo, OyuncuSoyadi = oyuncusoyadi, OyuncuAdi = oyuncuadi, DogumYılı = dogumyili, SozlesmeYili = sozlemeyili });

                }
                else if (seçim == 2)
                {
                    Console.WriteLine("Silmek İstediğin Oyuncunun Tc Numarası");
                    oyunYoneticisi.Sil(Console.ReadLine());



                }
                else if (seçim == 3)
                {

                    oyunYoneticisi.OyunListesi();


                }
                else if (seçim == 4)
                {
                    Console.WriteLine("Eklemek istediğiniz oyunun bilgilerini giriniz");
                    Console.WriteLine("Oyun Adı:");
                    string OyunAdi = Console.ReadLine();
                    Console.WriteLine("Oyunun Türü:");
                    string OyunTuru = Console.ReadLine();
                    Console.WriteLine("Oyunun Fiyatı:");
                    double OyunFiyati = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Oyunun İnceleme Puanı:");
                    oyunYoneticisi.Add(new Oyun() { OyunAdı = OyunAdi, OyunFiyati = OyunFiyati, OyunTuru = OyunTuru });



                }

                else if (seçim == 5)
                {
                    Console.WriteLine("Silmek istediğiniz oyuncunun Adını giriniz:");
                    oyunYoneticisi.Sil(Console.ReadLine());
                }
                else if (seçim == 6)
                {
                    oyunYoneticisi.OyunListesi();
                }
                else if (seçim == 7)
                {
                    Console.WriteLine("**********KAMPANYALAR**********");
                    Console.WriteLine("1- Duygu Kampanyası" + "  " + "2-Fatih Kampanası" + "  " + "3-Ana Menüye Dön");
                    Console.WriteLine("*******************************");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (secim2 == 1)
                    {
                        oyunYoneticisi.OyunListesi();
                        Console.WriteLine("Yukarıdaki oyunlardan öğrencisi kampanyası uygulamak istediğiniz oyunun adını yazınız:");
                        string isim = Console.ReadLine();
                        Console.Clear();
                        IKampanyaBilgi kampanya = new Kampanya1();
                        oyunYoneticisi.OyunAl(isim, kampanya);
                    }
                    else if (secim2 == 2)
                    {
                        oyunYoneticisi.OyunListesi();
                        Console.WriteLine("Yukarıdaki oyunlardan kara cuma kampanyası uygulamak istediğiniz oyunun adını yazınız:");
                        string isim = Console.ReadLine();
                        Console.Clear();
                        IKampanyaBilgi kampanya = new Kampanya2();
                        oyunYoneticisi.OyunAl(isim, kampanya);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Programdan çıkış yaptınız.İyi günler...");
                    break;
                }
            }
        
        }
    }
}
