using System.Collections;

namespace ArrayListAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Nəzəri   

            #region ArrayList
            //Array array =new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //Iterator

            // 2 4 6 8

            //for (int i = 0;; i++)
            //{

            //}

            /*
             foreach(type variable in array)
            {

            }
             
             */

            //foreach(var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Index ındex = 2;

            //int[] arr = new int[1];

            //Console.WriteLine(arr.IsFixedSize);



            // ArrayList arrayList = new ArrayList();

            //arrayList.Add(4);
            //arrayList.Add(5);
            //arrayList.Add(6);
            //arrayList.Add(7);
            //arrayList.Add(8);
            //arrayList.Add(9);
            //arrayList.Add(10);
            //arrayList.Insert(1, "Salam");
            //arrayList.Remove("Salam");

            //arrayList.RemoveAt(2);

            //arrayList.RemoveRange(3, 3);

            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //arrayList.Capacity = 20;

            //Console.WriteLine(arrayList.IsFixedSize);

            //arrayList.Add(5);
            //arrayList.Add("hello");
            //arrayList.Add("hello");
            //arrayList.Add("hello");
            //Console.WriteLine(arrayList.Capacity);

            //Console.WriteLine(arrayList.IsFixedSize);

            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(arrayList.Capacity);
            //arrayList.Clear();

            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(arrayList.Capacity);


            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(5);
            //arrayList.Add(10);

            //var a = arrayList[0];
            //var b = arrayList[1];

            //var result = (int)a + (int)b;

            //Console.WriteLine(result);

            //List<string> list = new List<string>();

            //list.Add("S");
            //list.Add();
            //list.Add(4);

            //List<int> list1 = new List<int>();

            //list1.Add(5);

            #endregion

            #region String
            //string word = "Codelandia";

            //foreach (var item in word)
            //{
            //    Console.WriteLine(item);
            //}

            //string nullText = null;
            //string emptyText = "1";


            //if (string.IsNullOrEmpty(nullText))
            //{
            //    Console.WriteLine("Deyer null ve ya emptydir");
            //}
            //else
            //{
            //    Console.WriteLine("Deyer null ve ya empty deyil");
            //}

            //string a = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(emptyText))
            //{
            //    Console.WriteLine("Null or Empty");
            //}
            //else
            //{
            //    Console.WriteLine("Is not empty or null");
            //}


            //string text1 = "Hello ";
            //string text2 = "World";
            //string text3 = "World2";


            //string result = text1 + text2;

            //Console.WriteLine(result);

            //string result = string.Format("{0} Daxil etdiyiniz sözlər {1} {1}  {2}", text1, text2,text3);

            //string name = "Parviz";
            //string surname = "Hajili";
            //int age = 24;

            //string res = string.Format("Adınız: {0}, Soyadınız: {1}, Yaşınız: {2}", name, surname, age);
            //Console.WriteLine(res);

            //string name = "Parviz ";
            //string surname = "Hajili";
            //int age = 24;

            //string result = $"Adınız: {name}, Soyadınız: {surname}, Yaşınız: {age}";
            //Console.WriteLine(result);

            //string message = @" Select * from Students
            //                    where age>20";

            //Console.WriteLine(message);

            //string result = string.Concat(name, surname);

            //string result = string.Join(".", name, surname,age);

            //Console.WriteLine(result);
            //string text = "CodelaNdiA";
            //string result = text.Substring(2,3);
            //string result = text.Remove(2,5);

            //string result = text.Trim(' ');
            //string result = text.ToLower();
            //string result = text.ToUpper();
            //string result = text.Insert(4,"salam");
            //bool result = text.Contains('c');

            //string text = "Is not empty,null hello.world";
            //string[] result = text.Split(' ',',','.');



            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}

            //string text = "Codelandia";
            ////var result = text.EndsWith('b');
            //var result = text.StartsWith('b');
            //Console.WriteLine(result);



            //Console.WriteLine(result);
            #endregion

            #endregion


            #region Praktiki
            #region Task1
            // stringdə olan natural ədədləri toplamaq
            //string word = "S456lam39";
            //int sum = 0;
            //foreach (char c in word)
            //{
            //    if (char.IsDigit(c))
            //    {
            //        sum += int.Parse(c.ToString());
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Task2
            //Istifadəçi daxil etdiyi mətn içərisində neçə ədəd
            //a hərfi olduğunu tapmaq
            //string text = Console.ReadLine();
            //int count = 0;
            //foreach (char c in text)
            //{
            //    if (c == 'a')
            //    {
            //        count+=1;
            //    }
            //}
            //Console.WriteLine(count);




            #endregion

            #region MyRegion
            // Aşağıda verilmiş mətni hazır metod istifadə etmədən tərsinə yazdırın
            //string text = "Codelandia";

            //string reversedText = "";

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    reversedText += text[i];
            //}

            //Console.WriteLine(reversedText);
            #endregion

            #endregion

        }
    }
}
