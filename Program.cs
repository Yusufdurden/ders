internal class Program
{
    private static void Main(string[] args)
    {
        //yenidenGiris:
        //Console.Write("Ay sayısını giriniz");
        ////1...12
        //int ay;
        //ay = int.Parse(Console.ReadLine());

        //switch (ay)
        //{
        //   case 1:
        //        Console.WriteLine("Ocak ayı");

        //        break;
        //    case 2:
        //        Console.WriteLine("Şubat ayı");

        //        break;
        //    case 3:
        //        Console.WriteLine("Mart ayı");

        //        break;
        //    case 4:
        //        Console.WriteLine("Nisan ayı");

        //        break;
        //    case 5:
        //        Console.WriteLine("Mayıs ayı");

        //        break;
        //    case 6:
        //        Console.WriteLine("Haziran ayı");

        //        break;
        //    case 7:
        //        Console.WriteLine("Temmuz ayı");

        //        break;
        //    case 8:
        //        Console.WriteLine("Ağustos ayı");

        //        break;
        //    case 9:
        //        Console.WriteLine("Eylül ayı");

        //        break;
        //    case 10:
        //        Console.WriteLine("Ekim ayı");

        //        break;
        //    case 11:
        //        Console.WriteLine("Kasım ayı");

        //        break;
        //    case 12:
        //        Console.WriteLine("Aralık ayı");

        //        break;

        //    default: Console.WriteLine("Yanlış girdiniz lütfen 1-12 arasında giriniz.");

        //        goto yenidenGiris;





        Console.Write("Puan giriniz A,B,C,D,F   =    ");

        char puan;


        puan= char.Parse(Console.ReadLine());

        switch (char.ToUpper(puan))
        {
            case 'a':
            case 'A':
                Console.WriteLine("Pek iyi");
                break;
            case 'b':
            case 'B':
                Console.WriteLine("İyi");
                break;
            case 'c':
            case 'C':
                Console.WriteLine("Orta");
                break;
            case 'd':
            case 'D':
                Console.WriteLine("Hmmmm");
                break;
            case 'f':
            case 'F':
                Console.WriteLine("Kaldı");
                break;
            default:
                Console.WriteLine("Yanlış giriş!");
                break;

        }


























    }













}
