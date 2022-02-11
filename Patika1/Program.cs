using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("isminize giriniz :");
            String Ad = Console.ReadLine();
            Console.WriteLine("SoyAdınıze Giriniz :");
            String SoyAd = Console.ReadLine();
            Console.WriteLine("Merhaba" + " " + Ad + "" + SoyAd);
        }
    }
}