using System.Text;

namespace C__002.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Nəzəri


            //type [] myArr = new type [capacity];

            //int[] ints = new int[10];
            //string[] strings = new string[10];

            //int[] myArr = { 1, 2, 34, 5, 6, 7, 8, 9 };
            //int[] myArr2 = myArr;


            //int value1 = 20;
            //int value2 = value1;

            //value1 = 50;

            //Console.WriteLine(value1); 
            //Console.WriteLine(value2); 


            //int[] myArr = { 1, 2, 34, 5, 6, 7, 8, 9 };
            //int[] myArr2 = myArr;

            //myArr[2] = 45;

            //Console.WriteLine(myArr[2]);
            //Console.WriteLine(myArr2[2]);


            //string[] cities = { "Baku", "Ganja", "Lankaran" };

            //string[] cities2 = cities;

            //cities[4] = "Ankara";

            //Console.WriteLine(cities[4]);

            //Console.WriteLine(cities2[1]);

            //int[] arr = new int[] { 1, 2, 3 };

            //Array array = new int[] { 4, 7, 2, 3 };

            //int a = arr[0];
            //int b = (int)array.GetValue(2);

            //int myArrayLength = arr.Length;
            //Console.WriteLine(myArrayLength);

            //int[] students = new int[5];

            //students[3] = 5;

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            //string[] names = new string[10];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //int[] myArr = { 9, 5, 34, 15, 6, 87, 8, 19 };
            //int[] myArr2 = new int[20];

            //Array.Clear(myArr);

            //Array.Reverse(myArr);

            //Array.Copy(myArr,5, myArr2, 3,3);

            //Array.Sort(myArr);

            //Array.Copy()



            //for (int i = 0; i < myArr2.Length; i++)
            //{
            //    Console.WriteLine(myArr2[i]);
            //}

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(myArr[i]);
            //}

            //Array array = new int[] { 4, 7, 2, 3 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array.GetValue(i));
            //}


            //int[] myArr = { 3, 4, 68, 6 };
            //int[] myArr2 = new int[myArr.Length];



            //Array.Copy(myArr,myArr2,myArr.Length);

            //for (int i = 0; i < myArr2.Length; i++)
            //{
            //    Console.WriteLine(myArr2[i]);
            //}

            //int[] myArr = new int[10];

            //Array.CreateInstance(typeof(int),10);

            // Range ve Indices ..  ^

            //int[] myArr = { 55,74,25,19,22,77,43,21};
            //Index ındex = 2;
            //int a = myArr[ındex];
            //Console.WriteLine(a);

            //Range range = 3..^0;

            //var myRangedArr = myArr[range];

            //for (int i = 0; i < myRangedArr.Length; i++)
            //{
            //    Console.WriteLine(myRangedArr[i]);
            //}

            //Console.WriteLine("Codelandia");

            //int[] myArr = { 55, 74, 5, 19, 22, 77, 43, 21 };

            //int min = myArr[0];
            //int max = myArr[0];

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    if (myArr[i] < min)
            //        min = myArr[i];

            //    if (myArr[i] > max)
            //        max = myArr[i];
            //}

            //Console.WriteLine(min);
            //Console.WriteLine(max);



            /*
             int[] myArr = { 55, 74, 5, 19, 22, 77, 43, 21 };
            int a = 5;
            Istifadeci daxil etdiyi ededi massivde axtarmaq

             */
            //int number = Convert.ToInt32(Console.ReadLine());
            //int[] myArr = { 55, 74, 5, 19, 22, 77, 43, 21 };
            //bool value = false;

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    if (myArr[i] == number)
            //        value = true;
            //}

            //if (!value)
            //{
            //    Console.WriteLine("Axtardığınız ədəd tapıldı" + number);
            //}
            //else
            //{
            //    Console.WriteLine("Axtardığınız ədəd tapılmadı");
            //}

            #endregion

            #region Homework1

            //Console.Write("Daxil ediləcək elementlərin sayı: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("1-ci ədəd: ");
            //int number = int.Parse(Console.ReadLine());
            //int min = number;
            //int max = number;
            //double sum = number;
            //for (int i = 1; i < n; i++)
            //{
            //    Console.Write("{0}-ci ədəd: ", i + 1);
            //    number = int.Parse(Console.ReadLine());
            //    if (number < min)
            //        min = number;
            //    if (number > max)
            //        max = number;

            //    sum += number;
            //}
            //Console.WriteLine("Min: " + min);
            //Console.WriteLine("Max: " + max);
            //Console.WriteLine("Avg: " + (sum / n));
            #endregion

            #region Homework2
            /*
             2. İstifadəçi daxil etdiyi ədədin rəqəmlərinin sayı qədər 
                5ə vurub cavabı ekrana yazdırın. 
             */
            /*int number = int.Parse(Console.ReadLine());//25
            int tempNumber = number;
            int count = 0;
            int fivePow = 1;
            while (tempNumber > 0)
            {
                tempNumber = tempNumber / 10;
                fivePow = fivePow * 5;
                count++;
            }
            Console.WriteLine(number * fivePow);*/
            #endregion

            /*Console.Write("Daxil ediləcək elementlərin sayı: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.Write("1-ci ədəd: ");
            array[0] = int.Parse(Console.ReadLine());
            int max= array[0];
            int min= array[0];
            double sum = array[0];
            for (int i = 2; i <= n; i++)
            {
                Console.Write("{0}-ci ədəd: ",i);
                array[i-1] = int.Parse(Console.ReadLine());
                if (max < array[i-1])
                    max = array[i-1];
                if(min > array[i-1])
                    min = array[i-1];
                sum += array[i-1];
            }
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Avg: " + (sum / n));*/


            #region Task5
            ///Istifadəçidən bir ədəd alınan massivdə axtarır
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 9 };

            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Console.WriteLine("Axtarılan dəyərin indeksi " +i);
                }
            }

            
            #endregion

            #region Task6
            //Tekrarlanan elementlerin sayini tapmaq

            //int[] array = { 1, 2, 3, 4, 3, 5, 6, 3, 7, 9 };

            //int value = Convert.ToInt32(Console.ReadLine());
            //int count = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == value)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"{value} Ədədi massivdə {count} dəfə təkrarlanıb");
            #endregion

            //int[] array = { 1, 2, 3, 4, 3, 5, 6, 3, 7, 9 };

            //int sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine(sum);
        }
    }
}
