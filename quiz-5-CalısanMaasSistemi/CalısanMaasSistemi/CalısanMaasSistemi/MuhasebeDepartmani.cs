using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalısanMaasSistemi
{
    class MuhasebeDepartmani : Personel
    {
        public MuhasebeDepartmani()
        {
            Hakedis = 5;
        }
        public override double MaasHesap()
        {
            int ay = DateHesapla();
            if (ay % 2 == 0)
            {
                Prim = Maas / 2;
                Maas += Prim;
            }
            else
            {
                Console.WriteLine("bu ay maasınız primsiz yatirilacaktir.");
            }
            int bolum_ = ay / 12;
            if (bolum_ > 0)
            {
                Hakedis = bolum_ * Hakedis;
            }
            else
            {
                Hakedis = 0;
            }

            return Maas;

        }
    }
}
