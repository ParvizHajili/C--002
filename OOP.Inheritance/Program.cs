using System.Diagnostics;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace OOP.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OOP
            //Encapsulation,Abstraction,Inheritance,Polimorphism
            //Mentor mentor = new Mentor();
            //mentor.Age = 10;

            ///D d = new D();
            //A a = new A();
            //Teacher teacher = new Teacher();
            //teacher.Talking();

           // Human human = new Human(5,5);

           // Student teacher = new Student(5,5);

            //overload
            //override

            Teacher teacher = new Teacher();
            teacher.Walking();
        }
    }

    #region MyRegion
    //class A 
    //{
    //    public int MyProperty { get; set; }   
    //}

    //class B : A
    //{
    //    public string Name { get; set; }

    //    public B()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}

    //class C : B
    //{
    //    public C()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}

    //class D : C
    //{
    //    public D()
    //    {
    //        Console.WriteLine("D");
    //    }
    //}
    #endregion


    class Human
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Human()
        {
            Console.WriteLine("Human");
        }

        public Human(int a)
        {
            X = a;
            Console.WriteLine("Human 1");
        }

        public Human(int a, int b) 
        {
            Y = b;
            Console.WriteLine("Human 2");
        }
        //public void Talking()
        //{
        //    Console.WriteLine("Human talking");
        //    //some code 
        //    //some code 
        //    //some code 
        //    //some code 
        //    //some code 
        //}

        public virtual void Walking()
        {
            Console.WriteLine("Human walking");
        }
    }

    class Teacher : Human
    {
        public Teacher() :base()
        {
            Console.WriteLine("Teacher");
        }

        public Teacher(int a) : this()
        {
            Console.WriteLine("Teacher1");
        }

        public Teacher(int a ,int b) 
        {
            Console.WriteLine("Teacher2");
        }

        public override void Walking()
        {
            Console.WriteLine("Teacher walking");
        }

        //public void Talking()
        //{
        //    base.Talking();

        //    //Console.WriteLine("Teacher talking");
        //}
    }

    class Student : Teacher
    {
        public Student()
        {
            
        }

        public Student(int a,int b) :base()
        {
            Console.WriteLine("Student");
        }
    }

    class Mentor : Human
    {

    }
}
