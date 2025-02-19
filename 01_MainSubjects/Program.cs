using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");
            //Console.Read();

            //Console.WriteLine("--- Yemek kategorileri ---");
            //Console.WriteLine();
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Tatlılar");
            //Console.WriteLine("3- İçecekler");
            //Console.WriteLine("4- Çorbalar");
            //Console.WriteLine("5- Salatalar");
            //Console.WriteLine("6- Soğuk Başlangıçlar");
            //Console.WriteLine();
            //Console.WriteLine("--- Yemek kategorileri ---");

            //Console.Read();
            #endregion

            #region String Değişkenler

            //string

            //Değişken_türü değiken_adı = değer;

            //string name;
            //name = "Emir";
            //Console.Write(name);     

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Bora";
            //customerSurname = "Demir";
            //customerPhone = "1234567890";
            //customerEmail = "customer@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("-- Rezervasyon Kartı --");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Müşteri Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("------------------------------------");

            //Console.WriteLine();

            //customerName = "Erdal";
            //customerSurname = "Kaya";
            //customerPhone = "0987654321";
            //customerEmail = "test@gmail.com";
            //district = "Körfez";
            //city = "Kocaeli";

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Müşteri Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("------------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 200;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("----Kızartma fiyatı: " + friesPrice + " TL");
            Console.WriteLine("----Kola fiyatı: " + cokePrice + " TL");
            Console.WriteLine("----Limonata fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine("----Su fiyatı: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int waterCount;
            int cokeCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 5;
            cokeCount = 2;
            waterCount = 4;
            lemonadeCount = 3;
            pizzaCount = 0;
            friesCount = 3;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice =  cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Toplam Tutar: " + (totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice) + " TL");
            Console.WriteLine("--------------------------------------------");

            #endregion
            Console.Read();
        }
    }
}
