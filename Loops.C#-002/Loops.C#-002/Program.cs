using System.Collections.Concurrent;
using System.Text;

namespace Loops.C__002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region StudentEaxamPoint
            //İlkin səviyyə üçün "Initial" (1-dən 3-ə qədər),
            //orta üçün "Average" (4-dən 6-ya qədər),
            //kafi üçün "Sufficient" (7-dən 9-a qədər) və
            //yüksək səviyyə üçün "High" (10-dan 12-yə qədər)
            //sözlərini çıxışa verin.

            //int point = int.Parse(Console.ReadLine());

            //switch (point)
            //{
            //    case < 1:
            //        Console.WriteLine("Point must be between 1 and 12");
            //        break;
            //    case 4:
            //        Console.WriteLine("Initial");
            //        break;
            //    case < 7:
            //        Console.WriteLine("Average");
            //        break;
            //    case < 10:
            //        Console.WriteLine("Sufficient");
            //        break;
            //    case < 13:
            //        Console.WriteLine("High");
            //        break;
            //    default:
            //        Console.WriteLine("Point must be between 1 and 12");
            //        break;
            //}
            #endregion
            #region MaxValue
            // Üçrəqəmli ədəd verilmişdir.
            // Onun rəqəmlərindən hansının (birincinin, yoxsa axırıncının)
            // böyük olduğunu müəyyənləşdirin.
            //Çıxışa göstərilən rəqəmlərdən böyüyünü verin.
            //Onlar bərabər olduqda "=" işarəsini verin.

            //int digit = int.Parse(Console.ReadLine());//123

            //int one = digit / 100;//1

            //int end = digit % 10;//3

            //if (one < end)
            //{
            //    Console.WriteLine("End:" + end);
            //}
            //else if (one > end)
            //{
            //    Console.WriteLine("One: " + one);
            //}
            //else
            //{
            //    Console.WriteLine("One==End:" + one + "==" + end);
            //}
            #endregion

            #region 
            // for  while  do while
            // foreach bir iteratordur

            /*
             
             for(    ;    ;    )
            {

            }
             */


            //for (int i = 10; i >= 0; i -= 2)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(i*5);
            //    Console.WriteLine("======"+i);
            //}


            //for (int i =0; ; i++)
            //{
            //    Console.WriteLine("Codelandia");
            //}

            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine("Codelandia");
            //}

            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //bool value = true;
            //int i = 1;

            //while (value && i < 5)
            //{  
            //    Console.WriteLine("Codelandia");              
            //    if(i==3)
            //        value = false;
            //    i++;
            //}


            //string a = "A";
            //int i = 1;
            //while (a == "A")
            //{
            //    Console.WriteLine("Codelandia");
            //    if (i == 4)
            //    {
            //        a = "a";
            //    }
            //    i++;
            //}

            //string a = "A";
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Codelandia");
            //    i++;
            //    if (i == 3)
            //        break;
            //} while (a == "A");

            //int i = 0;
            //string a = "A";
            //do
            //{
            //    i++;
            //    Console.WriteLine(i);

            //    if (i == 2)
            //    {
            //        a = "a";
            //        continue;
            //    }
            //} while (a == "A");


            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);

            //    if (i == 2)
            //    {
            //        continue;
            //    }
            //    i++;
            //} while (i<10);

            #endregion

            #region Practice
            #region Task1
            /*
             Ədədin 40-a 9-a 7-yə bölünməyini yoxlayın
             Əgər ədəd 40-a 9-a 7-yə bölünsə "Ədəd 40-a 9-a 7-yə" bölünür
             Əgər ədəd 40-a 9-a bölünsə "Ədəd 40-a və 9-a" bölünür
             Əgər ədəd 40-a bölünsə  "Ədəd 40-a" bölünür
             Ədəd 40-a 9-a 7-yə bölünmür.
             */

            //int a = Convert.ToInt32(Console.ReadLine());

            //if (a % 40 == 0)
            //{
            //    if (a % 9 == 0)
            //    {
            //        if(a % 7 == 0)
            //        {
            //            Console.WriteLine("Ədəd 40-a 9-a 7-yə bölünür");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ədəd 40-a 9-a bölünür");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ədəd 40-a bölünür");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ədəd 40-a 9-a 7-yə bölünmür");
            //}


            #endregion

            #region Task2
            /*Daxil edilen ededin faktorialini hesablayin*/
            // 5!  1*2*3*4*5

            //int a = 5;
            //int factorial = 1;

            //for (int i = 1; i <= a; i++)
            //{
            //    factorial = factorial * i;
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);
            #endregion

            #region Task3
            /* 0 daxil edilene kimi olan ededlerin cemini tapin.
             * while istifade etmekle */
            //int sum = 0;
            //int num;
            //do
            //{
            //    Console.WriteLine("Eded daxil edin:");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //} while (num != 0);

            //Console.WriteLine("Ededlerin cemi:" + sum);
            #endregion

            #region Task4
            /*
             for dovru istifade etmekle 1den 100-e qeder 3-e bolunen ededlerin
                cemini tapin
             */
            //int sum = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 3 == 0)
            //        sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Task5
            /*
             for dovru istifade etmekle 1den 100-e qeder 3-e bolunen ededlerin
                hasilini tapin
             */
            #endregion

            #region Task6
            /*
             1den 100-e qeder tek ededlerin ve cut ededlerin cemini tap
             */
            //int oddNums = 0;
            //int evenNums = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        oddNums += i;
            //    }
            //    else
            //    {
            //        evenNums += i;
            //    }
            //}

            //Console.WriteLine("Cüt ədədlər :" + oddNums);
            //Console.WriteLine("Tək ədədlər :" + evenNums);
            #endregion

            #region Task7
            /*
             1den 100-e qeder tek ededlerin ve cut ededlerin hasilini tap
             */
            //long oddNums = 1;
            //long evenNums = 1;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        oddNums *= i;
            //    }
            //    else
            //    {
            //        evenNums *= i;
            //    }
            //}

            //Console.WriteLine("Cüt ədədlər :" + oddNums);
            //Console.WriteLine("Tək ədədlər :" + evenNums);
            #endregion
            #endregion

        }
    }
}
