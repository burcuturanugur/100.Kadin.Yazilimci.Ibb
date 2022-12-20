internal class Program
{
    private static void Main(string[] args)
    {
        //string name;
        //string Name;

        //name = "Burcu"; //tab tuşuna basarak direkt yapmak istediğimiz işlemi tamamlayabiliriz.
        ////Atama işlemidir.
        //Name = "Arslan Mert Uğur";


        //Console.Write(name); //Sadece write yazdığımızda boşluk bırakmadan yazdırır.
        //Console.WriteLine(Name); //Bir alt satıra geçer.
        ////Console.ReadKey();//Ekrana yazdırdığımızda herhangi bir tuşa basılmadan kaybolmaması için yazılır.

        //string nameDesc;
        //string NameDesc;


        //nameDesc = "Benim adım : ----> " + name;
        //NameDesc = "Benim eşimin adı : ----> "+ Name;

        //Console.WriteLine(nameDesc);
        //Console.WriteLine(NameDesc);
        //Console.WriteLine(NameDesc+Name);
        //Console.WriteLine(nameDesc+name);

        //1. YÖNTEM
        byte a = 5;
        //byte b = 550; //0 ile 255 arasında değer alır o yuzden hata verecektir.
        byte b = 255;
        int sum = a + b;
        Console.WriteLine("Toplama işleminin sonucu " +sum);
       

        //2. YÖNTEM
        Console.WriteLine("Toplama işleminin sonucu : " +(a+b));
        Console.WriteLine("Toplama işleminin sonucu : " +sum.ToString()); //Sayısal değerini string yapar.

        String name;
        name= Console.ReadLine(); //String türünden değer girilmesi bekleniyor.
        Console.WriteLine("Adınız : " + name);

        //Debug menüsünden (Toggle Breakpoint) F9 ile işlemi adım adım izleyebiliriz. F9 ile seçtikten sonra çalıştırıp F11 ile ilerlemeyi gözlemleriz.
        //Aynı satırda farklı türden değişkenelr tanımlayamayız.Örn: int 5, String b;
        //Değişkene uygunsuz değer veremeyiz. Örn: int a; a="metin";
        //Değişkeni tanımlamadan ve/veya değişkene ilk değer vermeden değişkeni kullanmaya çalışmamalıyız. int b; Console.WriteLine(b); Console.WriteLine(a);
        //Değişken tanımlaması ve/veya değer vermeyi yanlış yerde yapmamalıyız.Örn: int a=5; static void Main(){}
        //Bazı değişken türlerindeki değişkenlere değer verirken eklenmesi gereken karakteri eklememek. Örn: float a =12.5; Console.WriteLine(a);
        //Ondalık sayıların ondalık kısmını ayırırken nokta yerine virgül kullanılmamalı
        //Metinsel değişkenlerle matematiksel işlem yapılmamalı. Örn: String a="5", b="2"; Console.WriteLine(a+b);
        //int c=Convert.ToInt32(a) + Convert.ToInt32(b) --> Stringi inte çeviririz.
        //Bir değişkeni birden fazla kez tanımlamak Örn: String a; String a="deneme";
       

        Console.ReadKey();

        






    }
}
