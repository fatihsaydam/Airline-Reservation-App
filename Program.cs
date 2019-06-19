using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {

        const int ToplamKoltukSayisi = BusinessKoltukSayisi + EconomyKoltukSayisi;
        const int BusinessKoltukSayisi = 8;
        const int EconomyKoltukSayisi = 12;

        static void Main(string[] args)
        {
            HavayoluRezervasyonuYap();            
        }

        static void Bekle()
        {
            Console.ReadKey();
        }

        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }

        static void EkranaYaz(int sayi)
        {
            EkranaYaz(sayi.ToString());
        }

        static char KlavyedenKarakterOku()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            return keyInfo.KeyChar;
        }

        static void EkraniTemizle()
        {
            Console.Clear();
        }

        static void BirTusaBas()
        {
            Console.WriteLine();
        }

        static int HavayoluRezervasyonuYap()
        {
            int sinifSecimi, koltukSecimi, s = 0;
            string yolcuAdi, input, input2;
            string[] koltukListesi = new string[ToplamKoltukSayisi] { null, "'Ahmet Özer'", null, "'Salih Durdu'", null, null, "'Hüseyin Özmen'", "'Sinan Kaya'", null, "'Asiye Leflef'", null, "'Mine Gezgin'", null, "'Uğur Kırcı'", "'Yusuf Ünal'", "'Nazlı Kayran'", null, null, "'Merve Toker'", "'Melike Pekel'" };

            while (s == 0)
            {
                EkranaYaz("1. Business Class için 1 tuşuna basın \n2. Economy Class için 2 tuşuna basın");

                char karakter = KlavyedenKarakterOku();

                bool donustuMu = int.TryParse(karakter.ToString(), out sinifSecimi);

                EkraniTemizle();

                if (donustuMu && (sinifSecimi == 1 || sinifSecimi == 2))
                {
                    if (sinifSecimi == 1)
                    {
                        if (koltukListesi[0] != null && koltukListesi[1] != null && koltukListesi[2] != null && koltukListesi[3] != null && koltukListesi[4] != null && koltukListesi[5] != null && koltukListesi[6] != null && koltukListesi[7] != null)
                        {
                            EkranaYaz("Seçtiğiniz Business Class bölümünde boş koltuk kalmamıştır. \nEconomy Class bölümünde kalan boş koltukları görmek istermisiniz ? E / H");

                            input2 = Console.ReadLine();

                            EkraniTemizle();

                            if (input2 == "E" || input2 == "e")
                            {
                                if (koltukListesi[8] != null && koltukListesi[9] != null && koltukListesi[10] != null && koltukListesi[11] != null && koltukListesi[12] != null && koltukListesi[13] != null && koltukListesi[14] != null && koltukListesi[15] != null && koltukListesi[16] != null && koltukListesi[17] != null && koltukListesi[18] != null && koltukListesi[19] != null)
                                {
                                    EkranaYaz("Economy Class bölümünde boş koltuk kalmamıştır. Devam etmek için bir tuşa basın.\n");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    EkraniTemizle();

                                    continue;
                                }

                                Console.WriteLine("Economy Class bölümünde kalan boş koltuklar: \n");

                                for (int i = BusinessKoltukSayisi; i < ToplamKoltukSayisi; i++)
                                {
                                    if (koltukListesi[i] == null)
                                        EkranaYaz("- " + (i + 1));
                                }

                                EkranaYaz("\nKoltuk numarası seçiniz.");
                                koltukSecimi = Convert.ToInt32(Console.ReadLine());
                                EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                EkraniTemizle();

                                if (koltukListesi[koltukSecimi - 1] != null)
                                {
                                    EkranaYaz(koltukSecimi + " numaralı koltuğa daha önce " + koltukListesi[koltukSecimi - 1] + " isimli yolcuya rezerve ettiniz!\n \nLütfen boş koltuklardan birini seçiniz.\n");

                                    EkranaYaz("\nBusiness Class bölümünde kalan boş koltuklar: \n");

                                    for (int i = 0; i < BusinessKoltukSayisi; i++)
                                    {
                                        if (koltukListesi[i] == null)
                                            EkranaYaz("- " + (i + 1));
                                    }

                                    EkranaYaz("\nKoltuk numarası seçiniz.");

                                    koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                    EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                    EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                    yolcuAdi = Console.ReadLine();

                                    koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                    EkraniTemizle();

                                    EkranaYaz("Business Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    continue;
                                }
                                else
                                {
                                    EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                    yolcuAdi = Console.ReadLine();

                                    koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                    EkraniTemizle();

                                    EkranaYaz("Business Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    EkraniTemizle();

                                    continue;
                                }
                            }
                            else if (input2 == "H" || input2 == "h")
                            {
                                EkranaYaz("Bir sonraki uçuş kayıtları 4 saat sonradır. \n");

                                continue;
                            }
                        }
                        else
                        {
                            EkraniTemizle();

                            EkranaYaz("Business Class bölümünde kalan boş koltuklar: \n");

                            for (int i = 0; i < BusinessKoltukSayisi; i++)
                            {
                                if (koltukListesi[i] == null)
                                    EkranaYaz("- " + (i + 1));
                            }

                            EkranaYaz("\nKoltuk numarası seçiniz.");

                            koltukSecimi = Convert.ToInt32(Console.ReadLine());

                            EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                            if (koltukSecimi<ToplamKoltukSayisi && koltukSecimi>BusinessKoltukSayisi)
                            {                                
                                EkraniTemizle();

                                EkranaYaz("Seçilen koltuk numarası= " + koltukSecimi);

                                EkranaYaz("Business Class koltukları 1-8 arasıdır. Lütfen boş koltuklardan birini seçiniz.");

                                EkranaYaz("Business Class bölümünde kalan boş koltuklar: \n");

                                for (int i = 0; i < BusinessKoltukSayisi; i++)
                                {
                                    if (koltukListesi[i] == null)
                                        EkranaYaz("- " + (i + 1));
                                }

                                EkranaYaz("\nKoltuk numarası seçiniz.");

                                koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                EkraniTemizle();

                                EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                yolcuAdi = Console.ReadLine();

                                koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                EkraniTemizle();

                                EkranaYaz("\nEconomy Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                input = Console.ReadLine();

                                BirTusaBas();

                                EkraniTemizle();

                                continue;
                            }

                            EkraniTemizle();

                            if (koltukListesi[koltukSecimi - 1] != null)
                            {
                                EkranaYaz(koltukSecimi + " numaralı koltuğa daha önce " + koltukListesi[koltukSecimi - 1] + " isimli yolcuya rezerve ettiniz! \nLütfen boş koltuklardan birini seçiniz.");

                                EkranaYaz("Business Class bölümünde kalan boş koltuklar: \n");

                                for (int i = 0; i < BusinessKoltukSayisi; i++)
                                {
                                    if (koltukListesi[i] == null)
                                        EkranaYaz("- " + (i + 1));
                                }

                                EkranaYaz("\nKoltuk numarası seçiniz.");

                                koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                EkraniTemizle();

                                EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                yolcuAdi = Console.ReadLine();

                                koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                EkraniTemizle();

                                EkranaYaz("\nEconomy Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                input = Console.ReadLine();

                                BirTusaBas();

                                EkraniTemizle();

                                continue;
                            }

                            else
                            {
                                EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                yolcuAdi = Console.ReadLine();

                                koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                EkraniTemizle();

                                EkranaYaz("\nBusiness Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                input = Console.ReadLine();

                                BirTusaBas();

                                EkraniTemizle();

                                continue;
                            }
                        }
                    }

                    if (sinifSecimi == 2)
                    {
                        if (koltukListesi[8] != null && koltukListesi[9] != null && koltukListesi[10] != null && koltukListesi[11] != null && koltukListesi[12] != null && koltukListesi[13] != null && koltukListesi[14] != null && koltukListesi[15] != null && koltukListesi[16] != null && koltukListesi[17] != null && koltukListesi[18] != null && koltukListesi[19] != null)
                        {
                            EkranaYaz("Seçtiğiniz Economy Class bölümünde boş koltuk kalmamıştır. \nBusiness Class bölümünde kalan boş koltukları görmek istermisiniz ? E / H");

                            input2 = Console.ReadLine();

                            EkraniTemizle();

                            if (input2 == "E" || input2 == "e")
                            {
                                if (koltukListesi[0] != null && koltukListesi[1] != null && koltukListesi[2] != null && koltukListesi[3] != null && koltukListesi[4] != null && koltukListesi[5] != null && koltukListesi[6] != null && koltukListesi[7] != null)
                                {
                                    EkranaYaz("Economy Class bölümünde boş koltuk kalmamıştır. Devam etmek için bir tuşa basın.\n");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    EkraniTemizle();

                                    continue;
                                }

                                Console.WriteLine("Business Class bölümünde kalan boş koltuklar: \n");

                                for (int i = 0; i < BusinessKoltukSayisi; i++)
                                {
                                    if (koltukListesi[i] == null)
                                        EkranaYaz("- " + (i + 1));
                                }

                                EkranaYaz("\nKoltuk numarası seçiniz.");

                                koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                EkraniTemizle();

                                if (koltukListesi[koltukSecimi - 1] != null)
                                {
                                    EkranaYaz(koltukSecimi + " numaralı koltuğa daha önce " + koltukListesi[koltukSecimi - 1] + " isimli yolcuya rezerve ettiniz! \nLütfen boş koltuklardan birini seçiniz.");

                                    EkranaYaz("Business Class bölümünde kalan boş koltuklar: \n");

                                    for (int i = 0; i < BusinessKoltukSayisi; i++)
                                    {
                                        if (koltukListesi[i] == null)
                                            EkranaYaz("- " + (i + 1));
                                    }

                                    EkranaYaz("\nKoltuk numarası seçiniz.");

                                    koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                    EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                    EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                    yolcuAdi = Console.ReadLine();

                                    koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                    EkraniTemizle();

                                    EkranaYaz("Business Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    continue;
                                }
                                else
                                {
                                    EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                    yolcuAdi = Console.ReadLine();

                                    koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                    EkraniTemizle();

                                    EkranaYaz("Business Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    EkraniTemizle();

                                    continue;
                                }
                            }
                            else if (input2 == "H" || input2 == "h")
                            {
                                EkraniTemizle();

                                EkranaYaz("Bir sonraki uçuş kayıtları 4 saat sonradır. \n");

                                continue;
                            }
                        }
                        else
                        {

                            EkranaYaz("Economy Class bölümünde kalan boş koltuklar: \n");

                            for (int i = BusinessKoltukSayisi; i < ToplamKoltukSayisi; i++)
                            {
                                if (koltukListesi[i] == null)
                                    EkranaYaz("- " + (i + 1));
                            }

                            EkranaYaz("\nKoltuk numarası seçiniz.");

                            koltukSecimi = Convert.ToInt32(Console.ReadLine());

                            EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                            if (koltukSecimi < BusinessKoltukSayisi+1 && koltukSecimi > 0)
                            {
                                EkraniTemizle();

                                EkranaYaz("Seçilen koltuk= " + koltukSecimi);

                                EkranaYaz("Economy Class koltukları 9-20 arasıdır. Lütfen boş koltuklardan birini seçiniz.");                                

                                EkranaYaz("Economy Class bölümünde kalan boş koltuklar: \n");

                                for (int i = BusinessKoltukSayisi; i < ToplamKoltukSayisi; i++)
                                {
                                    if (koltukListesi[i] == null)
                                        EkranaYaz("- " + (i + 1));
                                }

                                EkranaYaz("\nKoltuk numarası seçiniz.");

                                koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);                                

                                if (koltukListesi[koltukSecimi - 1] != null)
                                {
                                    EkranaYaz(koltukSecimi + " numaralı koltuğa daha önce " + koltukListesi[koltukSecimi - 1] + " isimli yolcuya rezerve ettiniz! \nLütfen boş koltuklardan birini seçiniz.");

                                    EkranaYaz("Economy Class bölümünde kalan boş koltuklar: \n");

                                    for (int i = BusinessKoltukSayisi; i < ToplamKoltukSayisi; i++)
                                    {
                                        if (koltukListesi[i] == null)
                                            EkranaYaz("- " + (i + 1));
                                    }

                                    EkranaYaz("\nKoltuk numarası seçiniz.");

                                    koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                    EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                    

                                    EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                    yolcuAdi = Console.ReadLine();

                                    koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                    EkraniTemizle();

                                    EkranaYaz("\nEconomy Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    EkraniTemizle();

                                    continue;
                                }
                                else
                                {
                                    EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                    yolcuAdi = Console.ReadLine();

                                    koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                    EkraniTemizle();

                                    EkranaYaz("\nEconomy Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                    input = Console.ReadLine();

                                    BirTusaBas();

                                    EkraniTemizle();

                                    continue;
                                }
                            }

                            else
                            {
                                if (koltukListesi[koltukSecimi - 1] != null)
                                {
                                    EkranaYaz(koltukSecimi + " numaralı koltuğa daha önce " + koltukListesi[koltukSecimi - 1] + " isimli yolcuya rezerve ettiniz! \nLütfen boş koltuklardan birini seçiniz.");

                                    EkranaYaz("Economy Class bölümünde kalan boş koltuklar: \n");

                                    for (int i = BusinessKoltukSayisi; i < ToplamKoltukSayisi; i++)
                                    {
                                        if (koltukListesi[i] == null)
                                            EkranaYaz("- " + (i + 1));
                                    }

                                    EkranaYaz("\nKoltuk numarası seçiniz.");

                                    koltukSecimi = Convert.ToInt32(Console.ReadLine());

                                    EkranaYaz("\nSeçilen koltuk numarası: " + koltukSecimi);

                                    EkraniTemizle();
                                }

                                EkranaYaz("\nLütfen yolcunun adını ve soyadını yazın.");

                                yolcuAdi = Console.ReadLine();

                                koltukListesi[koltukSecimi - 1] = yolcuAdi;

                                EkraniTemizle();

                                EkranaYaz("\nEconomy Class bölümündeki " + koltukSecimi + " numaralı koltuğu " + yolcuAdi + " isimli yolcuya rezerve ettiniz.\nDevam etmek için bir tuşa basın.");

                                input = Console.ReadLine();

                                BirTusaBas();

                                EkraniTemizle();

                                continue;
                            }
                        }
                    }
                }
                else
                {
                    EkraniTemizle();
                    continue;
                }
            }
            Bekle();
            return 0;            
        }
    }
}
