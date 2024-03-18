namespace C__002.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Try Catch

            //int a = 20;
            //int b = 0;

            //int res = a / b;

            //Console.WriteLine(res);
            //bool value = true;
            //try
            //{
            //    //int a = int.Parse(Console.ReadLine());

            //    //Console.WriteLine(a);

            //    int a = 20;
            //    int b = 0;

            //    int res = a / b;

            //    /*
            //     conn.Open();
            //    Some sql code                 
            //     */
            //}
            //catch(DivideByZeroException c)
            //{
            //    Console.WriteLine(c.Message);
            //}
            //catch(ArgumentNullException c)
            //{
            //    Console.WriteLine(c.Message);
            //}
            //catch (Exception e) when (value == false)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Bura həmişə işləyəcək");

            //    //conn.Close();
            //}

            //try
            //{
            //    //int a = int.Parse(Console.ReadLine());

            //    //Console.WriteLine(a);

            //    int a = 20;
            //    int b = 0;

            //    int res = a / b;

            //    /*
            //     conn.Open();
            //    Some sql code                 
            //     */
            //}
            //catch (DivideByZeroException c)
            //{
            //    Console.WriteLine(c.Message);
            //}
            //catch (ArgumentNullException c)
            //{
            //    Console.WriteLine(c.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Bura həmişə işləyəcək");

            //    //conn.Close();
            //}

            //logging


            //try
            //{
            //    int a = 20;
            //    int b = 0;

            //    int c = a / b;
            //}
            //catch (Exception c)
            //{
            //    Console.WriteLine("0-a bölmək olmaz");

            //}
            //finally
            //{ 
            //}

            //Console.WriteLine("Codelandia");
            //Console.WriteLine("Codelandia");
            //Console.WriteLine("Codelandia");
            #endregion

            #region Fibanoççi
            //0 1 1 2 3 5 
            //Cari ədəd özündən əvvəlki iki ədədin cəminə bərabərdir
            //İstifadəçidən bir dəyər alırıq
            //bu dəyər integer olmalıdır
            //İstifadəçi:0 ||| 0 1
            //İstifadəçi:1 ||| 0 1 1
            //İstifadəçi:2 ||| 0 1 1 2
            //İstifadəçi:3 ||| 0 1 1 2 3
            //İstifadəçi:4 ||| 0 1 1 2 3 5
            //İstifadəçi:5 ||| 0 1 1 2 3 5 8
            //İstifadəçi:6 ||| 0 1 1 2 3 5 8 13
            //İstifadəçi:7 ||| 0 1 1 2 3 5 8 13 21

            int digit = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;
            int third;
            Console.Write("0 1");
            for (int i = 0; i < digit; i++)
            {
                third = first + second;
                Console.Write(" "+third);
                first = second;
                second = third;
            }
            #endregion

        }
    }

    public class MyCustomException : Exception
    {
        public void Logging()
        {
             
        }
    }
}
