using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Temel veri tipleri
            /*
             * 8 bit  = 1byte  = 2 üzeri 8 tane değer tutar.
             * 16bit  = 2byte  = 2 üzeri 16 tane değer tutar
             * 32bit  = 4byte  = 2 üzeri 32 tane değer tutar.
             * 64bit  = 8byte  = 2 üzeri 64 tane değer tutar.
             * 128bit = 16byte = 2 üzeri 128 tane değer tutar.
             * 
             * ********************************************************************
             * Tam sayılar
             * ********************************************************************
             * byte -> 8bit 1 byte eder. 0-255 arasında değer tutan sayısal tiptir.
             * sbyte-> -128 +127 arası değer tutabilir.
             * short -> 2byte, -32768 +32767 arasında değer tutar
             * ushort-> 0-65535 arasındaki değerleri tutar.
             * int -> 4byte, -2,147 milyar +2,147 milyar arasındaki değerleri tutar. Integer varsayılan tamsayı tipidir.
             * uint -> 0->4,29 milyar arasındaki değerleri tutar.
             * long -> -çok => +çok arası değer tutar
             * ulong -> 0 => çok (19 hane) değer tutar.
             * 
             * ********************************************************************
             * Ondalıklı Tipler (Hassasiyet farkları önemlidir.)
             * ********************************************************************
             * float -> en küçük ondalıklı tip. ölçü birimlerinde kullanılır. "32 bit"
             * double -> matematiksel işlemler için kullanılır. varsayılan ondalıklı tip double dir. "64 bit"
             * decimal -> parasal ifadelerde kullanılır. "16 byte = 128 bit yer kaplar" 
             * 
             * ********************************************************************
             * Mantıksal Tipler
             * ********************************************************************
             * bool -> 1 bit yer kaplar. 0 veya 1 - true veya false.(cinsiyet gibi) işlemci mimarısı boolean üzerine gelişmiştir. çok fazla kullanılır.
             * 
             * ********************************************************************
             * Metinsel Tipler
             * ********************************************************************
             * char -> 1 karakter tutabilir 'A','z','7' gibi
             * string -> çok karakterden oluşan metin tutar. "bu bir string"
             * 
             * ********************************************************************
             * object -> herşeyi tutabilen tiptir. "everything as a object."
            */
            //Değişken Tanımlamak
            //tip isim = değer;
             /*
            byte yas = 25;
            sbyte sıcaklık = -5;
            char karakter = 'a';
            string metin = "merhaba ben bir string ifadeyim";

            object nesne = "metin girilir";
            nesne = 34;
            nesne = 1515156416254;
            nesne = 45.223;
            nesne = 'i';*/
            //integer tanımlama şekilleri

            int sayi1 = 5;
            int sayi2 = 3;
            int sayi3 = sayi1 * sayi2;

            //boolean

            bool bool1 = 10 < 2;
            Console.WriteLine(bool1);


            //degisken donusumleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //DateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            Console.WriteLine(" c# konsol uygulaması ile değişkenleri tanıdık");

            Console.WriteLine("Adem samuk c# konsol uygulaması");
        

         
        }
    }
}