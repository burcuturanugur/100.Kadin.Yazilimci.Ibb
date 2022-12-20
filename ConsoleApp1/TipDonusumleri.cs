using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable.World.NewFolder
{
    internal class TipDonusumleri
    {
        private static void Main(string[] args)
        {

            //Bilinçsiz tip dönüşümü: Implicit: Düşük kapasiteli bir değişken ve sabitlerden oluşan matematiksel ifade daha yüksek kapasiteli bir değişkene atanabilir.Bunun için
            //herhangi bir özel kod gerekmez.
            //Bilinçli tip dönüşümü: Explicit: Derleyicinin izin vermediği durumlarda kullanılır. Veri kayıpları gibi durumlar olabileceği için dikkatli kullanılmalıdır.

            // int i = 20;
            // byte b = (byte)i; //int bir değeri byte'a dönüştürmüş oluyoruz.

            byte a = 10;
            short b = 20;
            sbyte c = 30;
            int d = a + b + c; //Örnek bir tür dönüşümü (Bilinçsiz tip dönüşümü)
            string e = "IBB Project 100 KY";
            char f= 'A';
            object g = e + f + d;     //Bütün türleri(int,short,byte vb.) kapsayan bir veri türüdür.Farklı tiplerin object tipine atanması.
            long h = d;
            float i = h;
            double j = i;
            double k = 21.6;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d);
            Console.WriteLine(g.ToString());
            Console.WriteLine(g);
            Console.WriteLine("3.durum : " +h +k);

            //Bilinçsiz dönüşüm olayında ilginç bir durum 

            char l = 'A';
            int m = l;
            Console.WriteLine(m);

            //Tür dönüşüm örnekleri - Bilinçsiz

            Console.WriteLine(""); //Bir satır boşluk bıraktık.
            Console.WriteLine("Burcu\n\tUğur");

            int r = 15;
            byte s = (byte)r; //int bir değer byte'a dönüştürülmüştür.
            Console.WriteLine(s+r);
            Console.WriteLine(); // CW tab+tab kısayol. 




        }
    }
}
