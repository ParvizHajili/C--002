namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //1.Encapsulation
            //2.Inheritance
            //3.Polymorphism
            //4.Abstraction

            //Student student = new Human();

            //Student student = new Student();
            ////student.

            //Human human = new Student();
            //human.HumanTalk();

            //Human human1 = new Human();

            ////Teacher teacher = new Human();
            ///

            //Human teacher = new Teacher();

            //object student =  new Teacher();

            //Student student2 = student as Teacher;

            //if (student2 is not null)
            //{
            //    Console.WriteLine("Student is not null");
            //}
            //else
            //{
            //    Console.WriteLine("Student is null");
            //}

            // is a 
            // has a 
            // can do

            /*
             Association
             Aggregation
             Composition
             */
            #endregion

            /*
             Maşın kirayələmə proqramı
             Car,BiznessCar, EconomCar,LuxCar
             Masin nomresi,Marka,Model,Ili, 1Gun ucun Qiymeti,Masin aktivdir yoxsa yox

              1. Rent a car sahibi kimi daxil olma 
                  1-Masin elave et( secim olacaq ekonom yoxsa business)
                  1a-Ekonom
                  1b-Business
                  1c- Lux
                  2- Masinlara bax( 1-ekonom,2-business,3-lux)
                  3- Masin sil (masin nomresine gore) ( 1-ekonom,2-business,3-lux)

            2. Müştəri kimi daxil ol
            Business Masinlar Listi
            Ekonom Masinlar Listi
            Luks Masinlar Listi

            hansi kateqoriya masini secse sirf hemin kateqoriya gosterilsin
            daha sonra nomresini secsin
            secilmis nomre listden silinecek.
             */



        }

        #region 1
        //class Human
        //{
        //    public Human()
        //    {
        //        Console.WriteLine("Human");
        //    }
        //    public void Talk()
        //    {
        //        Console.WriteLine("Human");
        //    }
        //}

        //class Student : Human
        //{
        //    public Student()
        //    {
        //        Console.WriteLine("Student");
        //    }
        //    public void Talk()
        //    {
        //        Console.WriteLine("Student");
        //    }
        //}

        //class Teacher : Human
        //{
        //    public Teacher()
        //    {
        //        Console.WriteLine("Teacher");
        //    }
        //}

        //public interface ICar
        //{
        //    void Start();
        //}
        #endregion

        //public class Human
        //{
        //    public virtual void Talk()
        //    {

        //    }
        //}

        //public class Teacher : Human
        //{
        //    public sealed override void Talk()
        //    {

        //    }
        //}

        //public class Test : Human
        //{

        //}

    }
}
