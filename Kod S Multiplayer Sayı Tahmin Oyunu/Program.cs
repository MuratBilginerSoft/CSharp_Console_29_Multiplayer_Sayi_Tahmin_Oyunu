using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Multiplayer_Sayı_Tahmin_Oyunu
{
    class Program
    {
        #region Metodllar

        static int q;

        static public void baslık()
        {
            Console.WriteLine("                              *******************");
            Console.WriteLine("                              *SAYI TAHMİN OYUNU*");
            Console.WriteLine("                              *******************");

            for (q = 0; q < 3; q++)
                Console.WriteLine();
        }

        static public void yazar()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                             ***************************");
            Console.WriteLine("                             *WRITTEN BY MURAT BİLGİNER*");
            Console.WriteLine("                             ***************************");
            for (q = 0; q < 2; q++)
                Console.WriteLine();

        }

        #endregion


        static void Main(string[] args)
        {
        don:
            #region Değişkenler
            int[] toplam1 = new int[6];
            int[] toplam2 = new int[6];
            int[] dizi1 = new int[6];
            int[] dizi2 = new int[6];
            int[] gs1 = new int[6];
            int[] gs2 = new int[6];
            int q, u, x, i, t, l, k, m, km, x2, l1 = 0, l2 = 0, cv, cv1;
            int top = 0, b = 0, sonucc = 0, sonucc2 = 0, x3 = 3, vb = 0, vn = 0, b1 = 0, vb1 = 0, top1 = 0, vs = -1, vn2 = 0;
            string e, c, vm, isim1 = "", isim2 = "", d1, d2, d3;
            #endregion


            #region Karşılama Ekranı

            Console.Clear();

            baslık();

            Console.WriteLine(@"                            SINGLE PLAYER       s/S

                            MULTIPLAYER         m/M 
                             
                            AÇIKLAMA            a/A");
            Console.WriteLine();
            e = Console.ReadLine();
            Console.Clear();

            #endregion

            #region Açıklama Bölümü

            if (e == "a" || e == "A")
            {
                baslık();

                Console.WriteLine("                                  *AÇIKLAMA*");
                Console.WriteLine();

                Console.WriteLine("    Oyun bir sayı tahmin oyunudur.");
                for (q = 0; q < 1; q++)
                    Console.WriteLine();
                Console.WriteLine("                                 NASIL OYNANIR?");
                Console.WriteLine();
                Console.WriteLine(@"    Bilgisayar her bölüm için (1,50) arasında rastgele 6 sayı tutar.Ve oyun,bu
tuttuğu 6 sayıyı bulabilmeniz için sizden 6 tane sayı tahmininde bulunmanızı
ister.Oyunu tek başınıza oynayabileceğiniz gibi arkadaşınızla beraber oynayıp
daha fazla eğlenebilirsiniz.");
                Console.WriteLine();
                Console.WriteLine("                                  PUAN SİSTEMİ");
                Console.WriteLine();
                Console.WriteLine(@"Oyun her bölüm için kendisi (1,100) arasında bir sayı tutar.Bu tuttuğu sayı o
bölüm için 2 oyuncu içinde aynıdır. Bu sayı o bölüm aldığınız puana eklenecek
olan sayıdır.Bölümde eğer 1 sayıyı doğru tahmin ederseniz 10 puan 2 sayıyı 
tahmin ederseniz 30 puan, 3 sayıyı tahmin ederseniz 50, 4 sayıyı tahmin
ederseniz 80, 5 sayıyı tahmin ederseniz 100 ve eğer 6 sayıyıda doğru tahmin
ederseniz tam 1000 puanın sahibi olacaksınız.Her bölümden aldığınız puanların
toplamı oyunun galibini belirleyecek.");
                Console.WriteLine(@"Tek kişilik oyunu tercih ederseniz level sistemi devreye girer.Oyunun başlan
gıcında oyunun kaç tur olacağına siz karar verirsiniz.En fazla 10 tur seçe
bilirsiniz.Eğer direk oyuna başladerseniz oyun otamatik olarak 3 tur olarak
ayarlanır.LEVEL 1 de oyunu 1 tur olarak ayarlarsanız bölümü geçmek için 100
puan 2 tur olursa 200 puan 3 turolursa 300 4 tur olursa 500 5 tur olursa
600 6 tur olursa 700 7 tur olursa 800 8 tur olursa 900 9 tur olursa 950 ve
10 tur olursa 1000 puan almanız gerekir.");

                yazar();

                Console.WriteLine("                           ANASAYFAYA DÖNMEK İÇİN h/H BASINIZ. ");
                c = Console.ReadLine();
                Console.Clear();

                baslık();

                if (c == "h" || c == "H")
                {
                    goto don;
                }

            }
            #endregion


            #region Tek Kişilik Oyun

            else if (e == "s" || e == "S")
            {
                baslık();
                Console.Write("                             İSMİNİZİ GİRİNİZ=");
                isim1 = Console.ReadLine();

                Console.Clear();
                baslık();
                Console.WriteLine(@"                               SEÇENEKLER     s/S
                             

                              OYUNA BAŞLA     b/B");
                d1 = Console.ReadLine();
                Console.Clear();

                baslık();

                #region Oyun içinde Seçenekler

                if (d1 == "s" || d1 == "S")
                {

                    for (q = 0; q < 7; q++)
                        Console.WriteLine();

                    Console.Write("                           OYUN KAÇ TURDAN OLUŞSUN=");

                    x3 = int.Parse(Console.ReadLine());

                    #region Bölüm Geçilme Şartı

                    if (x3 == 1)

                        l2 = 100;
                    else if (x3 == 2)

                        l2 = 200;
                    else if (x3 == 3)

                        l2 = 400;
                    else if (x3 == 4)

                        l2 = 500;
                    else if (x3 == 5)

                        l2 = 600;
                    else if (x3 == 6)

                        l2 = 700;
                    else if (x3 == 7)

                        l2 = 800;
                    else if (x3 == 8)

                        l2 = 900;
                    else if (x3 == 9)

                        l2 = 950;
                    else if (x3 == 10)

                        l2 = 1000;
                    #endregion

                    #region Oyun Alanı Renk Seçimi

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("                       OYUN SAYFANIZIN RENK SEÇİMİNİ YAPINIZ");
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    Console.WriteLine(@"                              MAVİ          (m/M)

                             KIRMIZI        (k/K)

                              SARI          (s/S)

                              CYAN          (c/C)
                              
                              SİYAH         (HERHANGİ BİR TUŞ)");

                    string y = Console.ReadLine();
                    if (y == "m" || y == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                    }

                    else if (y == "k" || y == "K")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                    }
                    else if (y == "s" || y == "S")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                    }
                    else if (y == "c" || y == "C")
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                    }


                    Console.Clear();
                    #endregion

                    baslık();

                    goto don2;

                }

                #endregion

                #region Otomatik Oyun Kuralı Seçimi

                else if (d1 == "b" || d1 == "B")
                {

                    x3 = 3;
                    l1 = 200;

                }

                #endregion


            don2:

                #region Tek Kişilik Oyunda Level 1 in Başladığı Yer

                for (q = 0; q < 7; q++)
                    Console.WriteLine();


                Console.WriteLine("                                     LEVEL 1");

                Console.ReadKey();
                Console.Clear();

                baslık();

                for (u = 0; u < x3; u++)
                {
                    #region Loto Değerlerini Tut

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    Random r = new Random();

                    for (i = 0; i < dizi1.Length; i++)
                    {
                        do
                        {
                            x = r.Next(1, 50);
                        }
                        while (Array.IndexOf(dizi1, x) != -1);
                        dizi1[i] = x;
                    }

                    t = r.Next(1, 101);

                    for (q = 0; q < 4; q++)
                        Console.WriteLine();

                    #endregion

                    #region Kullanıcı Sayı Tahmini

                    for (l = 0; l < 6; l++)
                    {
                        Console.Write((l + 1) + ". Tahmininizi Giriniz=");
                        gs1[l] = int.Parse(Console.ReadLine());
                    }

                    baslık();

                    #endregion

                    #region Sonuçları Gör

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    Console.WriteLine("SONUÇLARI GÖRMEK İÇİN BİR TUŞA BASINIZ");

                    Console.ReadKey();

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    Console.WriteLine("ŞANSLI SAYILAR");
                    Console.WriteLine();

                    for (k = 0; k < 6; k++)
                    {

                        Console.Write("     " + dizi1[k]);

                    }


                    Console.WriteLine();
                    Console.WriteLine("ŞANSLI SAYILAR SIRALI ŞEKİLDE");
                    Console.WriteLine();

                    Array.Sort(dizi1);
                    foreach (int a in dizi1)
                        Console.Write("     {0}", a);

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    Console.WriteLine("TAHMİN ETTİĞİNİZ SAYILAR SIRALI");
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    Array.Sort(gs1);
                    foreach (int a in gs1)
                        Console.Write("     {0}", a);

                    Console.WriteLine();

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    Console.WriteLine("                                      SONUÇ");

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("TUTTURDUĞUNUZ SAYILAR");
                    Console.WriteLine();

                    #region Girilen Değerleri Karşılaştır
                    for (m = 0; m < 6; m++)
                    {
                        if (gs1[m] == dizi1[0] || gs1[m] == dizi1[1] || gs1[m] == dizi1[2] || gs1[m] == dizi1[3] || gs1[m] == dizi1[4] || gs1[m] == dizi1[5])
                        {
                            b++;
                            vb++;
                            Console.Write("    " + gs1[m]);

                        }
                    }

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    #endregion

                    #region Sonucu Gör

                    if (b == 0)
                    {
                        Console.WriteLine("ÜZGÜNÜZ HİÇ BİLEMEDİNİZ");
                        for (q = 0; q < 2; q++)
                            Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("TOPLAMDA " + b + " TANE BİLDİNİZ");
                        for (q = 0; q < 2; q++)
                            Console.WriteLine();
                    }
                    #endregion

                    #region Puanı Gör

                    if (vb == 0)
                        top = t;
                    else if (vb == 1)
                        top = 10 + t;
                    else if (vb == 2)
                        top = 30 + t;
                    else if (vb == 3)
                        top = 50 + t;
                    else if (vb == 4)
                        top = 80 + t;
                    else if (vb == 5)
                        top = 100 + t;
                    else if (vb == 6)
                        top = 1000 + t;


                    Console.WriteLine("BİLGİSAYARIN BU BÖLÜM İÇİN TUTTUĞU SAYI=" + t);
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("BU BÖLÜMDE " + top + " PUAN ALDINIZ");

                    Console.ReadKey();
                    Console.Clear();

                    baslık();

                    vs++;
                    toplam1[vs] = top;

                    #endregion

                    #endregion

                }

                #region Toplam Sonucu Gör

                for (km = 0; km < x3; km++)
                {
                    sonucc = sonucc + toplam1[km];
                }
                for (q = 0; q < 2; q++)
                    Console.WriteLine();

                Console.WriteLine("                                  PUAN TABLOSU");

                for (q = 0; q < 2; q++)
                    Console.WriteLine();

                Console.WriteLine("                                 " + isim1);
                Console.WriteLine();

                for (l1 = 0; l1 < x3; l1++)
                {
                    Console.WriteLine("                                      " + toplam1[l1]);
                    Console.WriteLine();
                }

                Console.WriteLine("                                 +");
                Console.WriteLine("                                 ------------- ");
                Console.WriteLine("                                   TOPLAM=" + sonucc);
                Console.ReadLine();
                Console.Clear();

                baslık();

                Console.Clear();
                #endregion

                #region Level Geçme Kontrolü

                if (sonucc < l2)
                {
                    baslık();

                    Console.WriteLine("      ÜZGÜNÜZ " + isim1 + " LEVEL 1 İ BAŞARILI BİR ŞEKİLDE BİTİREMEDİNİZ");
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine(@"                           TEKRAR OYNAMAK İÇİN     t/T 

                                   ÇIKMAK İÇİN     c/C");
                    d2 = Console.ReadLine();
                    Console.Clear();

                    if (d2 == "t" || d2 == "T")
                    {
                        baslık();
                        goto don2;

                    }
                    else
                    {
                        goto don3;
                    }

                }

                else if (sonucc == l2 || sonucc > l2)
                {
                    for (q = 0; q < 4; q++)
                        Console.WriteLine();
                    Console.WriteLine("                 TEBRİKLER " + isim1 + " LEVEL 1 İ BAŞARIYLA BİTİRDİNİZ");
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("                        2. BÖLÜME GEÇMEK İÇİN d/D BASINZ ");
                    d3 = Console.ReadLine();

                    Console.Clear();
                    baslık();


                    #region Level 2
                    if (d3 == "d" || d3 == "D")
                    {
                        for (q = 0; q < 7; q++)
                            Console.WriteLine();

                        Console.WriteLine("                                     LEVEL 2 Yapılandırılıyor.");

                    }

                    #endregion

                    else
                    {
                        goto don;
                    }
                }
                #endregion

                #endregion


            }

            #endregion


            #region İki Kişilik Oyun Başlangıç


            else if (e == "m" || e == "M")
            { // ÖZELLL 1 BU BLOK İKİ KİŞİLİK OYUN SEÇİLDİĞİNDE ÇALIŞACAK BLOKTUR...

                #region başlangıç
                baslık();

                Console.WriteLine("                                  1. OYUNCU");
                Console.WriteLine();
                Console.Write("                              İSMİNİZİ GİRİNİZ=");
                isim1 = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("                                  2. OYUNUCU");
                Console.WriteLine();
                Console.Write("                              İSMİNİZİ GİRİNİZ=");
                isim2 = Console.ReadLine();

                Console.Clear();

                baslık();

                #endregion

                #region Seçenekler

                for (q = 0; q < 5; q++)
                    Console.WriteLine();
                {
                    Console.WriteLine(@"                               SEÇENEKLER     s/S
                             

                              OYUNA BAŞLA     b/B");

                    d1 = Console.ReadLine();
                }
                Console.Clear();

                baslık();

                if (d1 == "s" || d1 == "S")
                { // 7 SEÇENEKLER BÖLÜMÜNÜN İÇİ
                    {
                        for (q = 0; q < 7; q++)
                            Console.WriteLine();

                        Console.Write("                           OYUN KAÇ TURDAN OLUŞSUN=");
                        x3 = int.Parse(Console.ReadLine());

                    }
                } // 7 nin bittiği yer
                else if (d1 == "b" || d1 == "B")
                {

                    x3 = 3;
                    l1 = 200;

                }

                #endregion

                #region Renk Seçimi

                for (q = 0; q < 2; q++)
                    Console.WriteLine();
                Console.WriteLine("                       OYUN SAYFANIZIN RENK SEÇİMİNİ YAPINIZ");
                for (q = 0; q < 2; q++)
                    Console.WriteLine();

                Console.WriteLine(@"                              MAVİ          (m/M)

                             KIRMIZI        (k/K)

                              SARI          (s/S)

                              CYAN          (c/C)
                              
                              SİYAH         (HERHANGİ BİR TUŞ)");

                string y = Console.ReadLine();
                if (y == "m" || y == "M")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }

                else if (y == "k" || y == "K")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
                else if (y == "s" || y == "S")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }
                else if (y == "c" || y == "C")
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }

                Console.Clear();
                baslık();

                #endregion


                for (u = 0; u < x3; u++)
                {

                    #region 1. Oyuncunun Bölümü

                    #region Sayıları Tutma
                    for (q = 0; q < 10; q++)
                        Console.WriteLine();

                    Console.WriteLine("                                  " + isim1);
                    Console.ReadKey();
                    Console.Clear();
                    baslık();

                    Random r = new Random();
                    t = r.Next(1, 101);

                    for (i = 0; i < dizi1.Length; i++)
                    {
                        do
                        {
                            x = r.Next(1, 50);

                        } while (Array.IndexOf(dizi1, x) != -1);
                        dizi1[i] = x;
                    }


                    for (q = 0; q < 4; q++)
                        Console.WriteLine();

                    #endregion


                    #region Sayı Tahmini Yap
                    for (l = 0; l < 6; l++)
                    {
                        Console.Write("              " + (l + 1) + ". Tahmininizi Giriniz=");
                        gs1[l] = int.Parse(Console.ReadLine());
                    }
                    // 37. BLOGUN BİTTİĞİ YER...


                    Console.Clear();
                    baslık();

                    #endregion

                    #region Sonucu Gör


                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("SONUÇLARI GÖRMEK İÇİN BİR TUŞA BASINIZ");

                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine("ŞANSLI SAYILAR");
                    Console.WriteLine();

                    for (k = 0; k < 6; k++)
                    {
                        Console.Write("     " + dizi1[k]);

                    }

                    Console.WriteLine();
                    Console.WriteLine("ŞANSLI SAYILAR SIRALI ŞEKİLDE");
                    Console.WriteLine();
                    Array.Sort(dizi1);
                    foreach (int a in dizi1)
                        Console.Write("     {0}", a);


                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("TAHMİN ETTİĞİNİZ SAYILAR SIRALI");

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Array.Sort(gs1);
                    foreach (int a in gs1)
                        Console.Write("     {0}", a);
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                      SONUÇ");

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("TUTTURDUĞUNUZ SAYILAR");
                    Console.WriteLine();

                    vb = 0;
                    b = 0;
                    for (m = 0; m < 6; m++)
                    {


                        if (gs1[m] == dizi1[0] || gs1[m] == dizi1[1] || gs1[m] == dizi1[2] || gs1[m] == dizi1[3] || gs1[m] == dizi1[4] || gs1[m] == dizi1[5])
                        {

                            b++;
                            vb++;
                            Console.Write("    " + gs1[m]);

                        }
                    }
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    if (b == 0)
                    {
                        Console.WriteLine("ÜZGÜNÜZ HİÇ BİLEMEDİNİZ");
                        for (q = 0; q < 2; q++)
                            Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("TOPLAMDA " + b + " TANE BİLDİNİZ");
                        for (q = 0; q < 2; q++)
                            Console.WriteLine();
                    }

                    if (vb == 0)
                        top = t;
                    else if (vb == 1)
                        top = 10 + t;
                    else if (vb == 2)
                        top = 30 + t;
                    else if (vb == 3)
                        top = 50 + t;
                    else if (vb == 4)
                        top = 80 + t;
                    else if (vb == 5)
                        top = 100 + t;
                    else if (vb == 6)
                        top = 1000 + t;


                    Console.WriteLine("BİLGİSAYARIN BU BÖLÜM İÇİN TUTTUĞU SAYI=" + t);
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("BU BÖLÜMDE " + top + " PUAN ALDINIZ");

                    toplam1[vn] = top;
                    vn++;
                    Console.ReadKey();
                    Console.Clear();

                    baslık();
                } // 46. BLOGUN BİTTİĞİ YER...
                    #endregion

                    #endregion

                #region 2. Oyuncunun Bölümü

                for (q = 0; q < 10; q++)
                    Console.WriteLine();

                for (u = 0; u < x3; u++)
                {
                    Random r = new Random();
                    t = r.Next(1, 101);

                    Console.WriteLine("                                  " + isim2);
                    Console.ReadKey();
                    Console.Clear();
                    baslık();

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();



                    for (i = 0; i < dizi2.Length; i++)
                    {
                        Random rt = new Random();
                        do
                        {
                            x2 = rt.Next(1, 50);

                        } while (Array.IndexOf(dizi2, x2) != -1);
                        dizi2[i] = x2;
                    }
                    for (q = 0; q < 4; q++)
                        Console.WriteLine();

                    for (l = 0; l < 6; l++)
                    {
                        Console.Write("             " + (l + 1) + ". Tahmininizi Giriniz=");
                        gs2[l] = int.Parse(Console.ReadLine());
                    }

                    Console.Clear();
                    baslık();

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("SONUÇLARI GÖRMEK İÇİN BİR TUŞA BASINIZ");

                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine();

                    Console.WriteLine("ŞANSLI SAYILAR");
                    Console.WriteLine();


                    for (k = 0; k < 6; k++)
                    {

                        Console.Write("     " + dizi2[k]);

                    }

                    Console.WriteLine();
                    Console.WriteLine("ŞANSLI SAYILAR SIRALI ŞEKİLDE");
                    Console.WriteLine();

                    Array.Sort(dizi2);

                    foreach (int a2 in dizi2)

                        Console.Write("     {0}", a2);

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("TAHMİN ETTİĞİNİZ SAYILAR SIRALI");

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();


                    Array.Sort(gs2);


                    foreach (int b2 in gs2)


                        Console.Write("     {0}", b2);
                    Console.WriteLine();




                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                      SONUÇ");

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("TUTTURDUĞUNUZ SAYILAR");
                    Console.WriteLine();

                    vb1 = 0;
                    b1 = 0;
                    for (m = 0; m < 6; m++)
                    {

                        if (gs2[m] == dizi2[0] || gs2[m] == dizi2[1] || gs2[m] == dizi2[2] || gs2[m] == dizi2[3] || gs2[m] == dizi2[4] || gs2[m] == dizi2[5])
                        {

                            b1++;
                            vb1++;
                            Console.Write("    " + gs2[m]);

                        }


                    }

                    for (q = 0; q < 2; q++)
                        Console.WriteLine();

                    if (b1 == 0)
                    {
                        Console.WriteLine("ÜZGÜNÜZ HİÇ BİLEMEDİNİZ");
                        for (q = 0; q < 2; q++)
                            Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("TOPLAMDA " + b1 + " TANE BİLDİNİZ");
                        for (q = 0; q < 2; q++)
                            Console.WriteLine();
                    }
                    {

                        if (vb1 == 0)
                            top1 = t;
                        else if (vb1 == 1)
                            top1 = 10 + t;
                        else if (vb1 == 2)
                            top1 = 30 + t;
                        else if (vb1 == 3)
                            top1 = 50 + t;
                        else if (vb1 == 4)
                            top1 = 80 + t;
                        else if (vb1 == 5)
                            top1 = 100 + t;
                        else if (vb1 == 6)
                            top1 = 1000 + t;
                    }
                    Console.WriteLine("BİLGİSAYARIN BU BÖLÜM İÇİN TUTTUĞU SAYI=" + t);
                    for (q = 0; q < 2; q++)
                        Console.WriteLine();
                    Console.WriteLine("BU BÖLÜMDE " + top1 + " PUAN ALDINIZ");

                    toplam2[vn2] = top1;
                    vn2++;
                    Console.ReadKey();
                    Console.Clear();


                    baslık();
                #endregion
                }
            }

            #region Puan Tablosu Oluştur

            for (km = 0; km < x3; km++)
            {

                sonucc = sonucc + toplam1[km];

            }
            for (km = 0; km < x3; km++)
            {

                sonucc2 = sonucc2 + toplam2[km];

            }

            for (q = 0; q < 2; q++)
                Console.WriteLine();

            Console.WriteLine("                                  PUAN TABLOSU");

            for (q = 0; q < 2; q++)
                Console.WriteLine();

            Console.WriteLine("                                 " + isim1);
            Console.WriteLine();

            for (cv = 0; cv < x3; cv++)
            {
                Console.WriteLine("                                      " + toplam1[cv]);
                Console.WriteLine();


            }

            Console.WriteLine("                                 +");
            Console.WriteLine("                                 ------------- ");
            Console.WriteLine("                                   TOPLAM=" + sonucc);

            for (q = 0; q < 2; q++)
                Console.WriteLine();


            Console.WriteLine("                                  " + isim2);
            Console.WriteLine();

            for (cv1 = 0; cv1 < x3; cv1++)
            {
                Console.WriteLine("                                      " + toplam2[cv1]);
                Console.WriteLine();
            }

            Console.WriteLine("                                 +");
            Console.WriteLine("                                 ------------- ");
            Console.WriteLine("                                   TOPLAM=" + sonucc2);


            Console.ReadKey();
            Console.Clear();
            baslık();

            for (q = 0; q < 10; q++)
                Console.WriteLine();

            if (sonucc > sonucc2)
            {
                Console.WriteLine("                            " + isim1 + " KAZANDI");
                Console.WriteLine();
                Console.WriteLine("                                    TEBRİKLER!!!");
            }
            else if (sonucc < sonucc2)
            {
                Console.WriteLine("                            " + isim2 + " KAZANDI");
                Console.WriteLine();
                Console.WriteLine("                                   TEBRİKLER!!!");
            }
            else
                Console.WriteLine("                                BERABERE KALDINIZ");
            Console.ReadKey();
            Console.Clear();
            baslık();

            for (q = 0; q < 10; q++)
                Console.WriteLine();

            Console.WriteLine("                        ANASAYFAYA DÖNMEK İÇİN (a/A) BASINIZ ");
            Console.WriteLine("                              ÇIKMAK İÇİN (c/C) BASINIZ");
            vm = Console.ReadLine();

            if (vm == "a" || vm == "A")
            {
                goto don;

            }
            else
            {
                Console.Clear();
                baslık();
                yazar();
            }

            #endregion
            #endregion

        don3:
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
