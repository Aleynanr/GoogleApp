using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApp
{
    class Program
    {
        //private static string d;
        //private static bool c; //true || (or) false
        //static int a; //private: başka bir classtan erişilemez. Bu yüzden static yapıldı.
        //static float b;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); //Burası bir yorum, bu fonksiyon console da Hello World yazılmasını sağlar.
            //Console.Write("Yenisatir");
            //Console.Write("DigerWrite");
            //Console.ReadLine(); // VE &&, VEYA ||


            //Console.WriteLine("Bu bir satırdır.");
            //Console.WriteLine("Bu da bir satırdır.");
            //Console.Write("\nBu bir sonraki satırdır.");
            //Console.Write("\nBu satır en alttadır.");
            //Console.ReadLine();

            //a = 1; //2 3 4 100
            //b = 1.1f;
            //c = true;
            //d = "birden fazla karakter";

            //Console.WriteLine(a);
            //Console.WriteLine(123);
            //Console.WriteLine(b);
            //Console.WriteLine(4.0m); //buradaki m küçük veya büyük harf olarak kullanılabilir.
            //Console.WriteLine(c);
            //Console.WriteLine(false); //logic operasyonlarında kullanılır. (mantık)
            //Console.WriteLine(d);
            //Console.ReadLine();

            //var tam = true; //var ile otomatik olarak bool  olduğunu anladı.
            //int tamSayi=7;
            //decimal ondalik;
            //string benimAdim; //string tanımı
            //float ondalikUcBasamakliSayi; //camel case
            //float OndalikSayi; //pascal Case
            //bool renkli;
            //benimAdim = "Aleyna Nur";
            //Console.WriteLine(benimAdim);
            //benimAdim = "Kılıç";
            //Console.WriteLine(benimAdim);
            //Console.WriteLine(tamSayi);
            //Console.WriteLine(tam);
            //Console.ReadLine();


            //İzmir'de bomba yedim tanesi 5 liraydı ve hava sıcaklığı 25,5 dereceydi.
            //string sehirIsmi = "İzmir"; //değişkeni var olarak da tanımlayabilirdik.
            //int fiyat = 5;
            //float havaSicakligi = 25.5f; //decimal olarak belirlenseydi m kullanılmalıydı. Floating için f kullanılır.
            //Console.Write(sehirIsmi);
            //Console.Write("\'de bomba yedim tanesi"+" ");
            //Console.Write(fiyat);
            //Console.Write(" "+"liraydı ve hava sıcaklığı"+" ");
            //Console.Write(havaSicakligi);
            //Console.Write(" "+"dereceydi.");
            //Console.ReadLine();


            // \n  \t  \"  \'  \\  @  \u1234
            //Console.WriteLine("Hello\nWorld");
            //Console.WriteLine("Hello\tWorld");
            //Console.WriteLine("\"Hello World\""); //"Hello World" yazmak istersek
            //Console.WriteLine("c:\\users\\aleyn\\appdata"); //c:\users\aleyn\appdata 
            //Console.WriteLine(@"c:\users\aleyn\appdata");
            //Console.ReadLine();


            string birinci = "Aleyna";
            string ikinci = "Unity Certified Instructor " + birinci;
            string ücüncü = ikinci + " " + "Nur Kılıç";
            string dördüncü = $"{birinci} {ikinci} elle yazı yazıyorum";
            string besinci = $@"c:\users\aleyn\{ikinci}\veri";
            Console.WriteLine(ücüncü);
            Console.WriteLine(dördüncü);
            Console.WriteLine(besinci);
            Console.ReadLine();






        }
    }
}
