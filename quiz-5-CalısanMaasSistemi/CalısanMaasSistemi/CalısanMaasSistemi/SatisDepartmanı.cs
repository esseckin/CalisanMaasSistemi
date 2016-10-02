using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalısanMaasSistemi
{
    class SatisDepartmanı : Personel,IHesaplar
    {
        int paketSayisi;
        public SatisDepartmanı()
        {
            Hakedis=10;
        }
        public void Hak() 
        {
            int ay=DateHesapla();
            int bolum_ = ay / 12;
            if (bolum_ > 0)
            {
                Hakedis = bolum_ * Hakedis;
            }
            else
            {
                Hakedis = 0;
            }
        }

        public override double SatisDepartmanı.MaasHesap(int gerekli)
        {
            paketSayisi = gerekli;
            int bolum = paketSayisi / 10;
            Prim = bolum * 0.25 * Maas;
            Maas += Prim;

            return Maas;
        }
    }
}
