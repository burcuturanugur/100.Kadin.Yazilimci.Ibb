internal class Program
{
    private static void Main(string[] args)
    {
        //Ekrana kullanıcıdan alınan sayısal bir bilgiyi ekrana yazınız.
        //Yazarken bilgilendirme mesajlarıyla birlikte olsun.

        int sayi = 0;
        Console.Write("Lütfen bir sayı giriniz: ");
        int cevap=int.Parse(Console.ReadLine()); //Parse yerine convert.Tounit32 kullanabiliriz.
        //Parse metodu ile integera çevriliyor.
        Console.WriteLine("Girdiğiniz sayı: {0}",cevap);
        Console.WriteLine("Lütfen programdan çıkmak için bir tuşa basınız... ");
        Console.ReadKey();

        //ÖDEV: 
        //Kullanıcıdan kenar bilgilerini alıp, bir dikdörtgenin alanını ve çevresini hesaplayınız.Sonucunu ekrana yazdırınız. 
        





    }
}