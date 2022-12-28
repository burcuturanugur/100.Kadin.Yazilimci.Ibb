//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //Ekrana kullanıcıdan alınan sayısal bir bilgiyi ekrana yazınız.
//        //Yazarken bilgilendirme mesajlarıyla birlikte olsun.

//        //int sayi = 0;
//        //Console.Write("Lütfen bir sayı giriniz: ");
//        //int cevap=int.Parse(Console.ReadLine()); //Parse yerine convert.Tounit32 kullanabiliriz.
//        ////Parse metodu ile integera çevriliyor.
//        //Console.WriteLine("Girdiğiniz sayı: {0}",cevap);
//        //Console.WriteLine("Lütfen programdan çıkmak için bir tuşa basınız... ");
//        //Console.ReadKey();

//        //ÖDEV: 
//        //Kullanıcıdan kenar bilgilerini alıp, bir dikdörtgenin alanını ve çevresini hesaplayınız.Sonucunu ekrana yazdırınız. 

//        ////Nested While Loop 1

//        //Console.Write("ENTER  A NUMBER ");
//        //int sayi = Convert.ToInt32(Console.ReadLine());
//        //int index = 1;
//        //while (index <= sayi)                                  
//        //{
//        //    Console.WriteLine();
//        //    int j = 1;
//        //    while (j <= index)
//        //    {
//        //        Console.Write(j + " ");                  // j indexten büyük olana kadar iterasyona devam eder. while döngüsü olduğu için 4 e geldiğinde 1-2-3ü de yazdırıyor.
//        //        j++;
//        //    }
//        //    index++;
//        //}

//        // Nested while loop 2
//        //int satir = 1; //Ekrana kare şeklinde bir şekil çizebiliriz bu şekilde
//        //while (satir <= 5)
//        //{
//        //    int sutun = 1;
//        //    while (sutun <= 5)
//        //    {
//        //        Console.Write(sutun + " ");
//        //        sutun++;
//        //    }
//        //    Console.WriteLine();
//        //    satir++;
//        //}

//        //#endregion

//        //#region 5. do while
//        //// nested do while
//        char Choice;
//        int MenuOption;
//        float Number1, Number2;
//        do
//        {
//            Console.WriteLine("Press 1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division");
//            MenuOption = Convert.ToInt32(Console.ReadLine());
//            switch (MenuOption)
//            {
//                case 1:
//                    Console.WriteLine("Enter the value of two numbers");
//                    Number1 = Convert.ToInt32(Console.ReadLine());
//                    Number2 = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine($"Sum Is {Number1 + Number2}");
//                    break;
//                case 2:
//                    Console.WriteLine("Enter the value of two numbers");
//                    Number1 = Convert.ToInt32(Console.ReadLine());
//                    Number2 = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine($"Difference Is {Number1 - Number2}");
//                   // Console.WriteLine("Difference Is {0}-{1}",Number1 - Number2); Bu şekilde de yazabiliriz.
//                    break;
//                case 3:
//                    Console.WriteLine("Enter the value of two numbers");
//                    Number1 = Convert.ToInt32(Console.ReadLine());
//                    Number2 = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine($"Multiplication Is {Number1 * Number2}");
//                    break;
//                case 4:
//                    Console.WriteLine("Enter the value of two numbers");
//                    Number1 = Convert.ToInt32(Console.ReadLine());
//                    Number2 = Convert.ToInt32(Console.ReadLine());
//                   // float bolumsonuc = (float)(Number1 / Number2);
//                    Console.WriteLine($"Division Is {Number1 / Number2}");
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice");
//                    break;
//            }
//            Console.WriteLine("Please Enter Y to continue, any keys to terminate");
//            Choice = Convert.ToChar(Console.ReadLine());
//        }
//        while (Char.ToUpper(Choice) == 'Y');

//        //#endregion


//        //Console.ReadKey();
//    }

//}



      





// //   }
////}