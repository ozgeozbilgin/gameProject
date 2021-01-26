using System;
using System.Collections.Generic;
using System.Text;

namespace gameProject
{
    class OyunYoneticisi
    {
        List<Oyun> oyunlar = new List<Oyun>() { };

        public void Add(Oyun oyun)
        {
            oyunlar.Add(oyun);
            Console.WriteLine("{0} isimli oyun eklendi", oyun.OyunAdı);
        }
        public void Sil(string OyunAdi)
        {
            foreach (var oyun in oyunlar)
            {
                if (oyun.OyunAdı == OyunAdi)
                {
                    oyunlar.Remove(oyun);
                    Console.WriteLine("{0} adında oyuncu oyundan silindi", oyun.OyunAdı);
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        public void OyunListesi()
        {
            int x = 1;
            foreach (var oyun in oyunlar)
            {

                Console.WriteLine("{0}. Oyunun Adı : {1} Oyunun Yazarı + {2} Oyunun Türü + {3} Oyunun Fiyati", oyun.OyunAdı, oyun.OyunuYapan, oyun.OyunTuru, oyun.OyunFiyati);
                x += 1;
            }


        }
        public void OyunAl(string OyunAdi, IKampanyaBilgi kampanya)
        {
            foreach (var oyun in oyunlar)
            {
                if (oyun.OyunAdı == oyun.OyunAdı)
                {
                    kampanya.SatısBilgisi(oyun);
                    kampanya.SatısıHesapla(oyun);

                }
                else
                {
                    continue;
                }
            }
        }

        internal void Add(YeniOyuncu yeniOyuncu)
        {
            throw new NotImplementedException();
        }

    }
}
