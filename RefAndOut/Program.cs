using System.Collections;
using System.Drawing;
using System.Text;

namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Nezeri


            #region Ref Out
            //int a = 40;
            //ref int b = ref a;

            //a = 100;

            //console.writeline(a);
            //console.writeline(b);
            //int a = 40;

            //Test(ref a);

            //Console.WriteLine(a);

            //Sum(10, 20, out int someValue);

            //Console.WriteLine(someValue);

            //add
            //update

            //Add("add", out string message);

            //Console.WriteLine(message);
            #endregion

            #region Math
            //5.4 => 5
            //5.7 => 6

            //var a = Math.Abs(-5);
            //var a = Math.Ceiling(5.7);
            //var a = Math.Floor(5.2);
            //var a = Math.Round(5.8);
            //var a = Math.Truncate(-5.6);
            //var a = Math.Sqrt(64.5);
            //var a = Math.Cbrt(27);
            //var a = Math.Pow(128,1/7.00);
            //Console.WriteLine(a);
            #endregion

            #region Datetime
            //DateTime dateTime = DateTime.Now;

            //string formatedDate = dateTime.ToString("dd MMM yyyy");
            //Console.WriteLine(formatedDate);


            #endregion

            #region Random
            //Random random = new Random();

            //var a = random.NextDouble();
            //Console.WriteLine(a);

            //int[] myArr = new int[10];

            //Random random = new Random();

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    myArr[i] = random.Next(1,100);
            //    Console.WriteLine(myArr[i]);
            //}

            //for (int i = 0;i < myArr.Length; i++)
            //{

            //}
            #endregion
            #endregion

            #region Praktiki

            #region Task1
            //metod iki eded parametr alacaq birinci parametr
            //cevireceyi deyer ikinci ise out acar sozu ile cevire
            //
            //string text = "asafd";
            //bool a = int.TryParse(text, out int value);
            //Console.WriteLine(a + " " + value);

            //int a = int.Parse(text);
            //Console.WriteLine(a);
            //Console.WriteLine("salam");



            //string text = "Salam";

            //bool isIntager = CustomTryParse(text, out int value);
            #endregion  Task1

            #region Task2
            //int[] myArr = { 1, 2, -3, 4, -5, };

            //bool value = FindNegativeElements(myArr, out ArrayList myList);
            //Console.WriteLine(value);

            //foreach (int item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //metod iki parametr alir 
            //I- integer massiv
            //II- out acar sozu ile yeni bir massiv verir

            //gonderilen massivin daxilinde menfi element varsa metod true 
            //yoxdursa false geri qaytarir ve
            //birnci hall ucun out acar sozu ile menfi elementleri geri qaytarir

            #endregion Task2

            #region Task3

            //1. Istifadeci sayini daxil etmek
            //2. Hemin saya uygun bir array yaratmaq
            //3. Random bir array yarat
            //4. Arrayleri qarsilasdir


            //Console.WriteLine("Oyunçu sayını daxil edin: ");
            //int playerCount = int.Parse(Console.ReadLine());

            //int[] playerNumbers = new int[playerCount];

            //int count = 1;
            //for (int i = 0; i < playerCount; i++)
            //{
            //    Console.WriteLine($"{count} Ədəd Daxil Edin.Daxil etdiyiniz ədəd 1-50 arasında olmalıdır.");
            //    int number = int.Parse(Console.ReadLine());
            //    playerNumbers[i] = number;
            //    count++;
            //}

            //Random rand = new Random();
            //int[] randomArray = new int[playerNumbers.Length];

            //for (int i = 0; i < randomArray.Length; i++)
            //{
            //    randomArray[i] = rand.Next(1, 50);
            //}

            //byte sameNumberCount = 0;

            //for (int i = 0; i < randomArray.Length; i++)
            //{
            //    for (int j = 0; j < playerNumbers.Length; j++)
            //    {
            //        if (randomArray[i] == playerNumbers[j])
            //            sameNumberCount++;
            //    }
            //}

            //Console.WriteLine("Nəticələr hesablanır zəhmət olmasa gözləyin.....");
            //Thread.Sleep(2500);

            //Console.WriteLine($"Uyğun gələn ədəd sayı :{sameNumberCount}");

            //if (sameNumberCount == 7)
            //{
            //    Console.WriteLine("Təbriklər siz cekpot qazandınız");
            //}
            //else if (sameNumberCount == 5)
            //{
            //    Console.WriteLine("Siz 1000 manat qazandınız");
            //}
            //else if (sameNumberCount < 5 && sameNumberCount > 3)
            //{
            //    Console.WriteLine("Siz 500 manat qazandınız");
            //}
            //else
            //{
            //    Console.WriteLine("Siz heçnə qazana bilmədiniz");
            //}

            //Console.WriteLine("Sizin daxil etdiyiniz ədədlər:");
            //foreach (int i in playerNumbers)
            //{
            //    Console.Write(i +" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Təsadüfi yaradılmış ədədlər:");
            //foreach (var item in randomArray)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Task4
            // 1-10 aralığında təsadüfi ədəd yaradın
            // ədəd daxil edin əgər 3 dəfədən çox səhv qeyd etsəz "Uduzdunuz" yazılsın
            // əks halda Təbriklər yazılsın.

            FindRandomNum(out string m);
            Console.WriteLine(m);

            #endregion

        }

        public static void FindRandomNum(out string message)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 10);

            int count = 0;

            while (count < 3)
            {
                Console.WriteLine("Ədəd daxil edin: ");
                int number = int.Parse(Console.ReadLine());

                if(randomNum == number)
                {
                    message = "Tebrikler Qazandınız";
                    return;
                }
                count++;
            }
            message = "Uduzdunuz";
        }
        #region Nezeri
        #region Ref Out

        //public static void Add(string name,out string message)
        //{
        //    if (name == "add")
        //        message = "Successfully Added";
        //    else if (name == "update")
        //        message = "Successfully Updated";
        //    else
        //        message = "Failed";
        //}

        //public static void Sum(int a, int b, out int result)
        //{
        //    result = a + b;
        //}

        //public static void Test(ref int a)
        //{
        //    a = 100;
        //}
        #endregion

        //public enum DatabaseConnection
        //{
        //    Sql=1,
        //    MySql=2,
        //    Oracle=3
        //}
        #endregion

        #region Praktiki
        #region Task1
        //public static bool CustomTryParse(string text, out int result)
        //{
        //    try
        //    {
        //        result = int.Parse(text);//ugig
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        result = 0;
        //        return false;
        //    }
        //}
        #endregion Task1

        #region Task2
        //public static bool FindNegativeElements(int[] arr, out ArrayList neqativeElementList)
        //{
        //    neqativeElementList = new ArrayList();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < 0)
        //            neqativeElementList.Add(arr[i]);
        //    }

        //    if (neqativeElementList.Count > 0)
        //        return true;
        //    return false;

        //}
        #endregion

        #endregion

    }
}
#endregion