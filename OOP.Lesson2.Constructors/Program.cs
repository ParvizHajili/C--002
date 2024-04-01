using System.Reflection.Metadata.Ecma335;

namespace OOP.Lesson2.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //MyClass myClass = new MyClass();
            //MyClass myClass1 = new MyClass();

            //myClass = myClass1;

            //(int age, string name) = Sum(10, "salam");

            //Console.WriteLine(age);
            //Console.WriteLine(name);
            //(int a,int b)= new MyClass(551,1551);

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int t = 5;

            //MyClass myClass = new MyClass();


        }

        //public static (int a, string b) Sum(int a, string b)
        //{
        //    return (a * 5, b);
        //}

        //public Test Sum(Test test)
        //{

        //    return new Test();
        //}

        //public class Test
        //{
        //    public int x { get; set; }
        //    public int y { get; set; }
        //    public string Name { get; set; }
        //    public bool Value { get; set; }
        //}
    }

    class MyClass1
    {

        //public MyClass()
        //{

        //}

        //public MyClass(int a, int b)
        //{

        //}

        //public void Deconstruct(out int a,out int b)
        //{
        //    a = 10;
        //    b = 20;
        //}
    }

    //class MyClass2
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Z { get; set; }

    //    public MyClass2()
    //    {
    //        Console.WriteLine("Prametrsiz");
    //    }

    //    public MyClass2(int x) : this()
    //    {
    //        Console.WriteLine("X parametri alan");
    //        X = x;
    //    }
    //    public MyClass2(int x, int y) : this(x)
    //    {

    //        Console.WriteLine("X ve y parametri alan");
    //        Y = y;
    //        //X = x;
    //    }

    //    private int age;

    //    public void Test()
    //    {
    //        this.age++;
    //    }

    //    public void Test(int age)
    //    {
    //        this.age = age;
    //    }

    //    ~MyClass2()
    //    {

    //    }
    //}
}
