using System;

namespace KodPatika6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Time = DateTime.Now.Hour;
            if (Time >= 6 && Time <= 11)
                Console.WriteLine("Günaydın");
            else if (Time <= 18)

                Console.WriteLine("İyi Günler");
            else
                Console.WriteLine("İyi Akşamlar");

            String sonuc = Time <= 18 ? "İyi Günler" : "İyi Akşamlar";

            sonuc = Time >= 6 && Time <= 12 ? "Günaydın!" : Time >= 12 && Time <= 18 ? "İyi Günler!" : Time > 18 && Time <= 10 ? "İyi Akşamlar!" : "İyi Geceler!"; 

            Console.WriteLine(sonuc);
            

        }
    }
}
