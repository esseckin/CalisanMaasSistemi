using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalısanMaasSistemi
{
    class Program
    {
        static Personel[] personels = new Personel[3];
        static int personelCount;
        static int error;
        static int secim;
        static ConsoleKeyInfo tus = new ConsoleKeyInfo();
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                error = 0;
                Console.WriteLine("-------------Menu------------");
                Console.WriteLine("1.personel kayıt \n2-Maas Hesapla\n3-Cıkıs");
                Console.WriteLine("Lütfen işlem seciniz:");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        PersonelKayit();
                        break;
                    case 2:
                        MaasHesap();
                        break;
                    case 3:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("hatalı giris.. Menüye yönlendiriliyorsunuz..");
                        Thread.Sleep(1000);
                        error++;
                        break;

                }
                if (error == 0)
                {
                    Console.WriteLine("Devam etmek icin bir tusa basın..");
                    tus = Console.ReadKey();
                }

            } while (error != 0 || tus.Key != ConsoleKey.Escape);

        }

        public static void MaasHesap()
        {
            int gerekli = 0;
            if (personelCount != 0) 
            {
                Console.WriteLine("tc nizi giriniz: ");
                string tc = Console.ReadLine();
                for (int i = 0; i < personelCount; i++)
                {
                    if (personels[i].Tc.Equals(tc))
                    {
                        if (personels[i].Departman==1)
                        {
                            Console.WriteLine("kac kisi yerlestirdiniz..");
                             gerekli = int.Parse(Console.ReadLine());
                             personels[i].MaasHesap(gerekli);

                        }
                        else if (personels[i].Departman == 2)
                        {
                            Console.WriteLine("kac paket sattınız.");
                            gerekli = int.Parse(Console.ReadLine());
                            personels[i].MaasHesap(gerekli);

                        }
                        else
                        {
                            personels[i].MaasHesap(0);
                        
                        }
                    } 
                }
                personels[personelCount].MaasHesap();
            }
            else
                Console.WriteLine("personel kaydı bulunmamakta");
        }
        public static void PersonelKayit()
        {
            do
            {
                Console.Clear();
                error = 0;
                Console.WriteLine("departmanlar");
                Console.WriteLine("1.İnsan Kaynaklari\n2.SatisDepartmani\n3.Muhasebe");
                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                    case 2:
                    case 3:
                        kayıt();
                        break;

                    default: Console.WriteLine("Hatalı giris.Men uye Yonlendiriliyorsunuz..");
                        Thread.Sleep(1000);
                        error++;
                        break;
                }
                HataKontrol();
            } while (error != 0 || tus.Key != ConsoleKey.Escape);

        }
        public static void HataKontrol()
        {
            if (error == 0)
            {
                Console.WriteLine("Devam etmek icin bir tusa basın..");
                tus = Console.ReadKey();
            }
        }
        public static void kayıt()
        {
            if (personelCount < personels.Length)
            {
                switch (secim)
                {
                    case 1: personels[personelCount] = new İnsanKaynakları(); break;
                    case 2: personels[personelCount] = new SatisDepartmanı(); break;
                    case 3: personels[personelCount] = new MuhasebeDepartmani(); break;
                    default:
                        break;
                }
                
                Console.WriteLine("TC: ");
                personels[personelCount].Tc = Console.ReadLine();
                Console.WriteLine("adiniz: ");
                personels[personelCount].Ad = Console.ReadLine();
                Console.WriteLine("soyadınız: ");
                personels[personelCount].Soyad = Console.ReadLine();
                personels[personelCount].Departman = secim;
                Console.WriteLine("Maasınız: ");
                personels[personelCount].Maas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ise giris tarihiniz: ");
                personels[personelCount].IseGiris = Convert.ToDateTime(Console.ReadLine());
                do
                {
                    error = 0;
                    Console.WriteLine("Calısma durumunuz (D/C): ");
                    char durum = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (durum == 'D')
                    {
                        personels[personelCount].Durum = true;

                    }
                    else if (durum == 'C')
                    {
                        personels[personelCount].Durum = false;
                        Console.WriteLine("Cıkıs tarihinizi giriniz..: ");
                        personels[personelCount].IstenCikis = Convert.ToDateTime(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("hatalı giris..Yeniden Deneyiniz..");
                        error++;
                    }
                   
                } while (error != 0);
            }
            else
            {
                Console.WriteLine("Artık kayıt alınamıyor.Biz sizi ararız..");
            }
            personelCount++;
            MaasHesap();
        }
    }
}
