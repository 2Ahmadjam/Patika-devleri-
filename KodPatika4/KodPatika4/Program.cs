using System;

namespace KodPatika4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* implicit converisiyon (bilişensiz Dönüşümü) ********");
            //implicit conversion (bilişensiz Dönüşümü)
            byte a = 30;
            sbyte b = 10;
            short c = 5;

            int d=a+b+c;
            Console.WriteLine("d:"+d);
            long h = d;
            Console.WriteLine("h:" + h);
            float i = h;
            Console.WriteLine("i:" + i);
            string e =  "Ahmad";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            Console.WriteLine("******** Explicit conversion(bilişenli Dönüşüm) *********");
            //Explicit conversion(bilişenli Dönüşüm)
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            Console.WriteLine("******* ToString metodu *******");
            //ToString metodu 
            int xx = 6;
            String yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            String zz = 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            //System.convert 
            Console.WriteLine("*** System.convert  sınıfı ***");
            String s1 = "10", s2 = "20";
            int sayı1, sayı2;
            int Toplam;
            sayı1 = Convert.ToInt32(s1);
            sayı2 = Convert.ToInt32(s2);

            Toplam = sayı1 + sayı2;

            Console.WriteLine("toplam :"+Toplam);
            //parse
            Console.WriteLine("*** Parse methudu ***");
            PaseMethod();
        }
        public static void PaseMethod() 
        {
            String metin1 = "10";
            String metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);

            Console.WriteLine("rakma1:"+rakam1);
            Console.WriteLine("double1:" + double1);
        }
    }
}
