namespace OOP.Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass(); 
            //MyClass.MyValidationDelegate
            #region Delegate
            //Console.WriteLine("Hello, World!");

            //XDelegate xDelegate = new XDelegate(ConsoleWriteFive);

            //Sum(4, xDelegate);
            //xDelegate += () =>
            //{
            //    Console.WriteLine("Test1");
            //};

            //xDelegate += () => { WriteName(); };


            //xDelegate += Test2;

            //xDelegate.Invoke();

            //xDelegate -= Test2;

            //xDelegate += () => { Test3(); };
            //xDelegate += () => { Test2(); };

            ////xDelegate += Sum(3);
            //xDelegate.Invoke();
            #endregion

            Student student = new()
            {
                FirstName = "Kanan",
                LastName = "Axundov",
                Age = -17
            };

            MyClass.MyCustomAddMethod(student);

            Console.WriteLine(MyClass.Students.Count);

            Console.ReadLine();
        }

        public delegate void XDelegate();

        public static void ConsoleWriteFive()
        {
            Console.WriteLine(5);
        }

        public static void WriteName()
        {
            Console.WriteLine("Name");
        }

        public static void Test2()
        {
            Console.WriteLine("Test2");
        }

        public static void Test3()
        {
            Console.WriteLine("Test3");
        }

        public static int Sum(int a, XDelegate xDelegate)
        {
            if (a == 5)
            {
                xDelegate.Invoke();
                //return 1;
            }
            return 1;
        }
    }
}
