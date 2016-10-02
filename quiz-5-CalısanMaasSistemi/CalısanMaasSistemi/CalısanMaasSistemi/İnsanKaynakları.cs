using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalısanMaasSistemi
{
    class İnsanKaynakları:Personel,IHesaplar
    {
        int yerlestirmeSayisi;

        public İnsanKaynakları()
        {
            Hakedis = 14;
        }
        public void Hak()
        {
            int ay = DateHesapla();
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

        public int YerlestirmeSayisi
        {
            get { return yerlestirmeSayisi; }
            set { yerlestirmeSayisi = value; }
        }

        public override double İnsanKaynakları.MaasHesap(int gerekli)
        {
            yerlestirmeSayisi = gerekli;
            int bolum=YerlestirmeSayisi/3;
            Prim = bolum * 0.10 * Maas;
            Maas += Prim;

            return Maas;
        }
    }
}
