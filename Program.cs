namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////for döngüsü örnekleri
            //// 1'den 10'a kadar olan sayıları yazdırma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //// 10'dan 1'e kadar olan sayıları yazdırma
            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //// 1'den 100'e kadar olan çift sayıları yazdırma
            //for (int i = 2; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //// 1'den 100'e kadar olan tek sayıları yazdırma
            //for (int i = 1; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //// 1'den 100'e kadar olan sayıları 5'er 5'er yazdırma
            //for (int i = 1; i <= 100; i += 5)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //// 1'den 100'e kadar olan sayıları 10'ar 10'ar yazdırma

            //for (int i = 1; i <= 100; i += 10)
            //{
            //    Console.WriteLine(i);
            //}   
            //Console.WriteLine();
            //// 1'den 100'e kadar olan sayıları 20'şer 20'şer yazdırma

            //for (int i = 1; i <= 100; i += 20)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //// 1'den 100'e kadar olan sayıları 25'er 25'er yazdırma
            //for (int i = 1; i <= 100; i += 25)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //WHILE
            //int i = 0;
            //while (i<10)
            //{
            //    Console.Write("Merhaba Okan");
            //    i++;
            //}
            //Console.ReadLine();
            //string name = "";
            //while (name != "+")
            //{
            //    Console.WriteLine("İsim gir:");
            //    name = Console.ReadLine();
            //}
            //Console.ReadLine();

            // 1 ile 100 arasında olan çift sayıları ekrana bastırın
            //1,50 arasındakı sayıları while ile toplayalım.
            //int i = 2;
            //while (i<=100)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}
            //Console.ReadLine();

            //int toplam = 0;
            //int k = 1;
            //while (k<50)
            //{
            //    toplam += k;
            //    k++;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            //string sifre = "1234";
            //string girilenSifre = "";
            //while (girilenSifre != sifre)
            //{
            //    Console.WriteLine("Lütfen şifrenizi giriniz:");
            //    girilenSifre = Console.ReadLine();
            //}
            //Console.ReadLine();
            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayi giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi % 2 == 0)
            //    {
            //        toplam += sayi;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tek sayi girdiniz. Program sonlandiriliyor.");
            //        break;
            //    }
            //}
            //Console.WriteLine($"Toplam: {toplam}");
            //Console.ReadLine();

            //int sayi = 0;
            //int sum =0;
            //while (sayi>=0)
            //{
            //    Console.WriteLine("Pozitif sayi giriniz :");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    sum += sayi;
            //}
            //sum= sum - sayi; // son girilen negatıf sayı cıkarttım.
            //Console.WriteLine($"Toplam: {sum}");
            //Console.ReadLine();
            //string isim = "okan";
            //string password = "1903";
            //while (true)
            //{
            //    Console.WriteLine("K.Adi gir: ");
            //     string name= Console.ReadLine();
            //    Console.WriteLine("Sifre gir: ");
            //    string sifre= Console.ReadLine();
            //    if (isim==name && password==sifre)
            //    {
            //        Console.WriteLine("Giris basarili");
            //        break;
            //    }
            //}
            //Console.ReadLine();
            //bool devam = true;
            //while (!devam)
            //{
            //    Console.WriteLine("K.adi gir :");
            //    string kullaniciAdi = Console.ReadLine();
            //    Console.WriteLine("Sifre gir :");
            //    string sifre = Console.ReadLine();
            //    if (kullaniciAdi == "okan" && sifre == "1903")
            //    {
            //        Console.WriteLine("Giris basarili");
            //        devam = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanici adi veya sifre yanlis. Tekrar deneyin.");
            //    }
            //}

            //double toplam = 0;
            //double ortalama = 0;
            //int sayac = 0;
            //while (sayac<5)
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    sayac++;
            //}
            //ortalama = toplam / 5;
            //Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
            //Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
            //Console.ReadLine();

            //int i = 1;
            //int toplam2 = 0;
            //while (i <= 100)
            //{
            //    if (i%5==0)
            //    {
            //        toplam2 += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(toplam2);



            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz (çıkmak için -1 girin):");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == -1)
            //    {
            //        Console.WriteLine("Program sonlandırılıyor.");
            //        break;
            //    }
            //    else if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine($"{sayi} bir çift sayıdır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{sayi} bir tek sayıdır.");
            //    }
            //}

            //int i = 1;
            //int adet = 0;
            //int toplam = 0;
            //while (i <= 100)
            //{
            //    if(i%7==0)
            //    {
            //        adet++;
            //        toplam += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(adet);
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            //Random = rastgele sayılar üretmek için kullanılır.
            //Random rnd= new Random();
            //int sayi1 = rnd.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üretir
            //Console.WriteLine("1 ile 100 arasında rastgele bir sayı üretildi. -> "+sayi1);

            // Kullanıcıdan tahmin al
            //int tahmin = 0;
            //int denemeSayisi = 0;

            //while (tahmin != sayi1)
            //{
            //    Console.Write("Tahmininizi girin (1-100): ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    denemeSayisi++;
            //    if (tahmin < sayi1)
            //    {
            //        Console.WriteLine("Daha yüksek bir sayı deneyin.");
            //    }
            //    else if (tahmin > sayi1)
            //    {
            //        Console.WriteLine("Daha düşük bir sayı deneyin.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tebrikler! {denemeSayisi} denemede doğru tahmin ettiniz.");
            //    }
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    int ascii=rnd.Next(65, 91); // 65 ile 90 arasında rastgele bir ASCII değeri üretir (A-Z)
            //    char karakter = (char)ascii; // ASCII değerini karaktere dönüştürür     
            //    Console.WriteLine($"Rastgele üretilen {i}. karakter: {karakter}");
            //}
            //Random rnd = new Random();
            //int number = 0;
            //while (number!=5)
            //{
            //    number = rnd.Next(1, 11);
            //    Console.WriteLine($"Rastgele üretilen sayı: {number}");
            //}
            //Console.WriteLine("5 sayısı üretildiği için program sonlandırılıyor.");

            //Random rnd = new Random();
            //int i = 1;
            //while (i <= 10)
            //{
            //    int sayi= rnd.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üretir
            //    if (sayi%2==0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    i++;
            //}
            //Console.ReadLine();


            //Random rnd = new Random();
            //int adet = 0;
            //int toplam = 0;
            //int ort = 0;
            //int i = 1;
            //while (i<=100)
            //{
            //    int sayi = rnd.Next(1, 101);
            //    if (sayi % 5 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //        toplam += sayi;
            //        adet++;
            //    }
            //    i++;
            //}
            //ort= toplam / adet;
            //Console.WriteLine($"5'e tam bölünen sayıların toplamı: {toplam}");
            //Console.WriteLine($"5'e tam bölünen sayıların adedi: {adet}");
            //Console.WriteLine($"5'e tam bölünen sayıların ortalaması: {ort}");

            //Console.ReadLine();

            //Random rnd = new Random();
            //int i = 1;
            //int sum = 0;
            //while (i<=10)
            //{
            //    int sayi = rnd.Next(1, 101);
            //    sum += sayi;
            //    i++;
            //}
            //Console.WriteLine($"Rastgele üretilen sayıların toplamı: {sum}");


        }
    }
}
