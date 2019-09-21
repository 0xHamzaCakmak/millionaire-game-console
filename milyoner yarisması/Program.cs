using System;

namespace milyoner_yarisması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************");
            Console.WriteLine("Yarismaya Hosgeldiniz..");
            Console.Title="Bilgi Yarisması";
            string ad, soyad;
            Console.Write("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.Write("Soyadınız: ");
            soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Başlıyoruz Enter Basınız...");
            Console.WriteLine("Her Yanıttan Sonra Enter Basmayınız");
            Console.WriteLine("Cevapları Büyük Harflerle Veriniz..");
            Console.ReadLine();
            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;
            string s1;
            Console.WriteLine("soru 1 - cumhuriyet Kaç yılında ilan edilmiştir ?");
            s1 = Convert.ToString(Console.ReadLine());
            string c1 ;
            Console.WriteLine(" A-1920\n B-1923\n C-1924\n D-1926\n Cevabınız: ");
            c1 = Console.ReadLine();
            if (c1 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s2;
            Console.WriteLine("Turkiye'nin başkenti neresidir? ");
            s2 = Console.ReadLine();
            string c2;
            Console.WriteLine(" A-İstanbul\n B-İzmir\n C-Ankara\n D-Konya\n Cevabınız: ");
            c2 = Console.ReadLine();
            if (c2 == "C")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s3;
            Console.WriteLine("Maki Bölgenin Bitki Örtüsüdür? ");
            s3 = Console.ReadLine();
            string c3;
            Console.WriteLine(" A-Akdeniz\n B-Ege\n C-Marmara\n D-Karadeniz\n Cevabınız: ");
            c3 = Console.ReadLine();
            if (c3 == "A")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s4;
            Console.WriteLine("Hangisi İstanbul'da Bulunan Semt Değildir? ");
            s4 = Console.ReadLine();
            string c4;
            Console.WriteLine(" A-Üsküdar\n B-Urla\n C-Sarıyer\n D-Kartal\n Cevabınız: ");
            c4 = Console.ReadLine();
            if (c4 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s5;
            Console.WriteLine("Hangisi programlamanın temel renklerinden değildir? ");
            s5 = Console.ReadLine();
            string c5;
            Console.WriteLine(" A-Mavi\n B-Yesil\n C-Kırmızı\n D-sarı\n Cevabınız: ");
            c5 = Console.ReadLine();
            if (c5 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s6;
            Console.WriteLine("Avrupanın Kullandıgı Ortak Para Birimi? ");
            s6 = Console.ReadLine();
            string c6;
            Console.WriteLine(" A-Dolar\n B-Euro\n C-Ruble\n D-Ziloti\n Cevabınız: ");
            c6 = Console.ReadLine();
            if (c6 == "A")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s7;
            Console.WriteLine("Hangi ilimiz ege bölgesinde değildir? ");
            s7 = Console.ReadLine();
            string c7;
            Console.WriteLine(" A-İzmir\n B-Aydın\n C-Muğla\n D-Edirne\n Cevabınız: ");
            c7 = Console.ReadLine();
            if (c7 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s8;
            Console.WriteLine("Sefiller Kitabının Yazarı Kimdir? ");
            s8 = Console.ReadLine();
            string c8;
            Console.WriteLine(" A-Julwen\n B-Gogo\n C-Tolsttoy\n D-Victor Hugo\n Cevabınız: ");
            c8 = Console.ReadLine();
            if (c8 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s9;
            Console.WriteLine("TMustafa Kemal Atatürk'ün Nüfüsa kayıtlı olduğu il hangisidir? ");
            s9 = Console.ReadLine();
            string c9;
            Console.WriteLine(" A-İstanbul\n B-GaziAntep\n C-Ankara\n D-Konya\n Cevabınız: ");
            c9 = Console.ReadLine();
            if (c9 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            string s10;
            Console.WriteLine("İstiklal Marşının Şairi Kimdir? ");
            s10 = Console.ReadLine();
            string c10;
            Console.WriteLine(" A-Ziya GÖkalp\n B-Mehmet Akif Ersoy\n C-Orhan Veli\n D-Neşat Nuri Gültekin\n Cevabınız: ");
            c10 = Console.ReadLine();
            if (c10 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.WriteLine("Tebrikler Doğru Cevap... Eneter Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.WriteLine("Malesef Yanlış CEvapladınız.. Enter Basınız");
                Console.ReadLine();
            }
            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Dogru sayınız: " + dogru);
            Console.WriteLine("Yanlış Sayınız: " + yanlis);
            Console.WriteLine("Toplam Kazandıgınız para: " + para);
            Console.WriteLine("Yarışma Bitmiştir");

            Console.Read();
        }
    }
}
