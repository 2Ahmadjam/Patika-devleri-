using System;

namespace KodPatika5
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine(" Bir sayı giriniz: ");
            //    int Sayı = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğunuz sayı : " + Sayı);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Hata :" + ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine(" İşlem tamamlandı ");
            //}
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(" Boş değer girdiniz :");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex ) 
            {
                Console.WriteLine("Çok büyük yada çok küçük bir değer girdiniz.");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.WriteLine("İşleminiz başarıyla tamamlandı.");
            }
        }
    }
}
