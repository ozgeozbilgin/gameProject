using System;
using System.Collections.Generic;
using System.Text;

namespace gameProject
{
    class OyuncuYoneticisi
    {
        List<Oyuncu> oyuncular = new List<Oyuncu>() { };
        public void Add(Oyuncu oyuncu)
        {
            oyuncular.Add(oyuncu);
            Console.WriteLine(" {0} {1} , adlı oyuncu sisteme eklendi", oyuncu.OyuncuAdi, oyuncu.OyuncuSoyadi);
        }
        public void Sil(string TcNo)
        {
            foreach (var oyuncu in oyuncular)
            {
                if (oyuncu.TcNo == TcNo)
                {
                    oyuncular.Remove(oyuncu);
                    Console.WriteLine("{0} {1} , adlı oyuncu oyundan silindi", oyuncu.OyuncuAdi, oyuncu.OyuncuSoyadi);
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        public void OyuncuBilgileriListele()
        {

            int x = 1;
            foreach (var oyuncu in oyuncular)
            {
                Console.WriteLine("{0}. Oyuncunun Adı + {1} Oyuncunun Soyadı + {2} Oyuncunun Doğum Yılı, {3} Oyuncunun Tc No'su", oyuncu.OyuncuAdi, oyuncu.OyuncuSoyadi, oyuncu.DogumYılı, oyuncu.TcNo);
                x += 1;
            }
        }
    }

}
