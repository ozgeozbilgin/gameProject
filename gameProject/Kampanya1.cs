using System;
using System.Collections.Generic;
using System.Text;

namespace gameProject
{
    class Kampanya1:IKampanyaBilgi
    {
        public void SatısBilgisi(Oyun oyun)
        {
            Console.WriteLine("{0} isimli kampanya1 uygulandı.\nYeni Fiyat:{1} TL\n", oyun.OyunAdı, oyun.OyunFiyati);
        }

        public void SatısıHesapla(Oyun oyun)
        {
            oyun.OyunFiyati -= oyun.OyunFiyati * (0.20);
        }
    }
}
