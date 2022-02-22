using System;

namespace KodPatika3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Atama ve işlemli atama operatörleri  *********");
            //Atama ve işlemli atama operatörleri
            int x = 3;
            int y = 2;
            y = y + 3;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);
            Console.WriteLine("******** Mantıksal Operatörleri *********");
            //Mantıksal Operatörler 
            // ||, &&, !
            bool isSeccess = true;
            bool isCompleted = false;
            if (isSeccess && isCompleted)
                Console.WriteLine("Perfecte!");
            if (isSeccess || isCompleted)
                Console.WriteLine("Great!");
            if (isSeccess && !isCompleted)
                Console.WriteLine("Fine!");
            Console.WriteLine("******** ilişkisel Operatörleri *********");
            // ilişkisel Operatörler 
            // <,>,<=,>=,==,!=
            int a = 3;
            int b = 5;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a !=b;
            Console.WriteLine(sonuc);
            Console.WriteLine("******** Aritmetik Operatörleri *********");
            //Aritmetik operatörleri 
            // /,*,+,-,
            int Sayı1 = 10;
            int Sayı2 = 5;
            int sonuc1 = Sayı1 / Sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = Sayı1 * Sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = Sayı1 + Sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = Sayı1 - Sayı2; ;
            Console.WriteLine(sonuc1);
            sonuc1 = Sayı1++;
            Console.WriteLine(Sayı1);

            Console.WriteLine("********* mod alan Operatörleri ***********");
            // % mod alınır 
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
