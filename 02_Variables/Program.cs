using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.72;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, bananaPrice, tomatoPrice, patatoPrice;

            //applePrice = 14.21;
            //orangePrice = 12.45;
            //strawberryPrice = 43;
            //bananaPrice = 82.99;
            //tomatoPrice = 51.99;
            //patatoPrice = 32.99;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice);
            //Console.WriteLine("---- Muz Birim Fiyatı:" + bananaPrice);
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice);
            //Console.WriteLine("---- Patates Birim Fiyatı:" + patatoPrice);

            //double appleGram, orangeGram, strawberryGram, bananaGram, tomatoGram, patatoGram;

            //appleGram = 1.245;
            //orangeGram = 1.450;
            //strawberryGram = 0.542;
            //bananaGram = 5.00;
            //tomatoGram = 7.50;
            //patatoGram = 2.780;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double bananaTotalPrice = bananaGram * bananaPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Muz - " + "Birim Fiyat: " + bananaPrice + " - Gramaj: " + bananaGram + " - Toplam Tutar: " + bananaTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + patatoPrice + " - Gramaj: " + patatoGram + " - Toplam Tutar: " + patatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + bananaTotalPrice + tomatoTotalPrice + patatoTotalPrice;

            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler
            //ABCDEFGH
            //char character = 'A';
            //Console.WriteLine(character);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passangerIdentityNumber + " - Yolcu Ad Soyad: " + passangerName + " " + passangerSurname + " - " + passangerDistrict + " / " + passangerCity + " " + passangerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1500;
            //computerPrice = 14500;
            //chairPrice = 2500;
            //tvPrice = 70500;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen Aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken miktar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("3 Sınav ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion


            Console.Read();
        }
    }
}
