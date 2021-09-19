using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı : " + sayi);
            }

            catch (Exception e)
            {
                Console.WriteLine("Hata : " + e.Message.ToString());
            }

            finally
            {
                Console.WriteLine("İşlem Tamamlandı.");
            }



            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex.Message);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
        }
    }
}
