using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı giriniz..: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : {0}", sayi.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı...");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz...   {0}", ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yanlış formatta girdiniz...   {0}", ex.ToString());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz...   {0}", ex.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı...");
            }
        }
    }
}
