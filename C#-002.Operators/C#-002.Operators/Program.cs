using System.Text;

namespace C__002.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Theoretical


            //int a = 20;
            //int b = 30;

            //var result = a + b;

            //decimal value1 = 450;
            //int value2 = 50;

            //var result = value1 + value2;


            //byte value1 = 10;
            //byte value2 = 20;
            //var res = value1 + value2;

            //int a = 100;
            //int b = 50;

            //var res = a - b;

            //int a = 10;
            //int b = 0;


            // ++ 
            //int a = 20;
            //a = --a;
            //Console.WriteLine(a);

            //a = --a;

            //Console.WriteLine(a);

            /*
             &&
             ||
             ^
             !
             */
            //bool value1 = !true;
            //bool value2 = false;

            //bool res = value1 ^ value2;

            //Console.WriteLine(res);
            // Console.WriteLine(value1);

            //int x = 10;
            //x.
            //int[] arr = { 1, 2, 3 };

            //int x = Convert.ToInt32(Console.ReadLine());

            //if (x == 5)
            //{
            //    Console.WriteLine("This is 5");
            //}
            //else if (x > 5)
            //{
            //    Console.WriteLine("X greater than 5");
            //}
            //else
            //{
            //    Console.WriteLine("This is not 5");
            //}

            //if (x == 3)
            //    Console.WriteLine("X is 3");
            //else
            //    Console.WriteLine("X is not 3");


            //int x = Convert.ToInt32(Console.ReadLine());

            //nested 
            //if (x > 10)
            //{
            //    if (x > 15)
            //    {
            //        Console.WriteLine("X 10 ve 15den boyukdur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("X 10dan boyukdur");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("X 10dan kicikdir");
            //}

            //if (x == 5)
            //{
            //    Console.WriteLine("True");
            //}
            //if (x == 10)
            //{
            //    Console.WriteLine("True");
            //}

            //{
            //    decimal c = 20;
            //    {

            //        {

            //            int b = 10;
            //        }
            //    }
            //}
            //var result = false;
            //string mes= string.Empty;
            //if (result)
            //{
            //    Console.WriteLine("1");
            //}
            //else
            //{
            //    Console.WriteLine("2");
            //}

            //string message = "Codelandia1";

            //if (message == "Codelandia")
            //{
            //    Console.WriteLine("Codelandia");
            //}
            //else
            //{
            //    Console.WriteLine("is not Codelandia");
            //}

            //string value = message == "Codelandia" ? "Codelandia" : "is not Codelandia";

            //Console.WriteLine(value);
            /*
             ?
            ??
            ??=
             
             */
            //int? a = null;
            //int b = a ?? 5;
            //Console.WriteLine(b);

            //int? a = 15;
            //int b = a ??= 5;
            //Console.WriteLine(b);
            //Console.WriteLine(a);

            //int month = 4;

            //var result = month switch
            //{
            //    1 => "Yanvar",
            //    2 => "Fevral",
            //    3 => "Mart",
            //    4 => "Aprel",
            //    _ => "Basqa eded daxil edin"
            //};

            //Console.WriteLine(result);
            //bool value = true;
            //bool value2 = true;
            //switch (month)
            //{
            //    case 1 when value == false && value2 == true:
            //        Console.WriteLine("Yanvar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevral");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Aprel");
            //        break;
            //    default:
            //        Console.WriteLine("Basqa eded daxil edin");
            //        break;
            //}


            //if(month == 1)
            //{
            //    Console.WriteLine("Yanvar");
            //}
            //else if(month == 2)
            //{
            //    Console.WriteLine("Fevral");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("Mart");
            //}
            //else if (month == 4)
            //{
            //    Console.WriteLine("Aprel");
            //}
            //else
            //{
            //    Console.WriteLine("Basqa eded daxil edin");
            //}
            #endregion

            #region Practical
            #region Task1
            //Switch case istifade ederek mini kalkulyator yazin
            //Console.Write("Birinci ədədi daxil edin: ");
            //int value1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Ikinci ədədi daxil edin: ");
            //int value2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Operatoru daxil edin: +,-,/,*");
            //char operand = Convert.ToChar(Console.ReadLine());

            //switch (operand)
            //{
            //    case '+':
            //        Console.WriteLine("Iki ədədin cəmi: " + (value1 + value2));
            //        break;
            //    case '-':
            //        Console.WriteLine("Iki ədədin fərqi: " + (value1 - value2));
            //        break;
            //    case '/':
            //        if(value2 == 0)
            //        {
            //            Console.WriteLine("0-a bölmək olmaz");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Iki ədədin qisməti: " + (value1 / value2));
            //        }
            //        break;
            //    case '*':
            //        Console.WriteLine("Iki ədədin hasili: " + (value1 * value2));
            //        break;
            //    default:
            //        Console.WriteLine("Düzgün operatordan istifadə edin!");
            //        break;
            //}

            #endregion
            #region Task2
            /*Verilmiş ədədin pifaqor olub-olmadığını yoxlayan proqram yaz*/
            //Console.Write("Birinci ədədi daxil edin: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Ikinci ədədi daxil edin: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Üçüncü ədədi daxil edin: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int aPow = a * a;
            //int bPow = b * b;
            //int cPow = c * c;

            //if (aPow + bPow == cPow)
            //{
            //    Console.WriteLine("Pifaqordur");
            //}
            //else if (aPow + cPow == bPow)
            //{
            //    Console.WriteLine("Pifaqordur");
            //}
            //else if (bPow + cPow == aPow)
            //{
            //    Console.WriteLine("Pifaqordur");
            //}
            //else
            //{
            //    Console.WriteLine("Pifaqor deyil");
            //}
            #endregion

            #region Task3
            //Dördrəqəmli natural ədəd verilmişdir.
            //Onun rəqəmlərinin kvadratları cəmini hesablayın
            /*int digit = int.Parse(Console.ReadLine());//1234
           
            int one = digit / 1000;//1

                           //12    -      10 =2
            int two = (digit / 100) - (one * 10);//2

                               //123   -     1*100 -   2*10   =3 
            int theeth = (digit / 10) - (one * 100) - (two * 10) ;//3
                      //1234  -   1*1000    -  2*100     -    3*10=4
            int four = digit  - (one *1000) - (two * 100) - (theeth * 10);//4

            int product = one* one + two* two + theeth * theeth + four * four;
            Console.WriteLine(product);*/

            /*int digit = int.Parse(Console.ReadLine());//1234

            int one = digit % 10;//4

            int two = (digit / 10) % 10;//3

            int theeth = (digit / 100) % 10;//2
            int four = (digit / 1000);//1

            int product = one * one + two * two + theeth * theeth + four * four;
            Console.WriteLine(product);*/

            #endregion

            #region Task4
            //Verilmiş üçrəqəmli natural ədədin
            //sonuncu rəqəminin birinci rəqəmə bölünməsindən
            //alınan qalığı hesablayın.
            /*int digit = int.Parse(Console.ReadLine());//123
            int one = digit / 100;
            //int end = digit % 10;
            int end = digit - ((digit / 10) * 10);
            //int qaliq =end - (end / one) * one;
            int qaliq = end % one;
            Console.WriteLine(qaliq);*/
            #endregion


            #region Task5
            /*
             a və b natural ədədləri verilmişdir. a-nın b-yə bölünməsini yoxlayın.

            Grirş verilənləri:
            İki natural(integer) a və b ədədləri.

            Çıxış verilənləri:
            a b-yə tam bölünmürsə, 
            tək sətirdə a-nın b-yə bölünməsindən 
            alınan tam və qalıq hissəni çap edin. 
            Əks halda "Tam bölünür" çap edin.*/
            //int one = int.Parse(Console.ReadLine());
            //int two = int.Parse(Console.ReadLine());

            //if (two != 0)
            //{
            //    if (one % two != 0)
            //    {
            //        Console.WriteLine("Tam hisse: " + one / two);
            //        Console.WriteLine("Qaliq hisse: " + one % two);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tam bolunur");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sifira bolmek olmaz");
            //}
            #endregion

            #endregion
        }
    }
}
