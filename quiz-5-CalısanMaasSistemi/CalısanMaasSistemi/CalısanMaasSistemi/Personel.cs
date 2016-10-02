using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalısanMaasSistemi
{
    class Personel
    {
        int departman;

        public int Departman
        {
            get { return departman; }
            set { departman = value; }
        }

        string ad;
        public Personel()
        {

        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        string tc;

        public string Tc
        {
            get { return tc; }
            set { tc = value; }
        }
        double maas;

        public double Maas
        {
            get { return maas; }
            set { maas = value; }
        }
        double prim;

        public double Prim
        {
            get { return prim; }
            set { prim = value; }
        }
        int hakedis;

        public int Hakedis
        {
            get { return hakedis; }
            set { hakedis = value; }
        }
        DateTime iseGiris;

        public DateTime IseGiris
        {
            get { return iseGiris; }
            set { iseGiris = value; }
        }
        DateTime istenCikis;

        public DateTime IstenCikis
        {
            get { return istenCikis; }
            set { istenCikis = value; }
        }
        bool durum;// true halen calısıyor:false cıkıs

        public bool Durum
        {
            get { return durum; }
            set { durum = value; }
        }

        public virtual double MaasHesap()
        {
            Console.WriteLine("personel maas hesap ");
            return 0.0;
        }

        public int DateHesapla() 
        { 
         int gunsayisi = 0;
            int ay = 0;

            if (Durum)
            {
                TimeSpan fark = DateTime.Now.Subtract(IseGiris);
                gunsayisi = fark.Days;
                ay = gunsayisi / 30;
            }
            else
            {
                Console.WriteLine("tüm hakedisleri odenmistir");
            }
            return ay;
        }

    }
}
