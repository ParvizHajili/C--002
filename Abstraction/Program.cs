namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            /*
           1. Encapsulation
           2. Inheritance
           3. Polymorphism
           4. Abstraction
           */
            //Console.WriteLine("Hello, World!");

            //Product product = new Product();
            //product.

            //Product product = new Product();

            //ProductCard productCard = new ProductCard();
            /// Product product = new Product();
            /// 
            //Student student = new Student();

            //Product productCard = new ProductCard();
            //productCard

            //Student student = new Student();
            //student.Talk();

            //IMainOperation product = new Product();
            //product.
            #endregion

            IProductOperation product = new Product();
            product.Test();
            //Product product1 = new Product();

        }
    }
    interface IMainOperation
    {

        void Test();
    }

    interface IProductOperation
    {
        void Test();
    }

    class Product : IMainOperation, IProductOperation
    {
        public Product() { }
        void IMainOperation.Test()
        {
            throw new NotImplementedException();
        }

        void IProductOperation.Test()
        {
            throw new NotImplementedException();
        }
    }

    #region Interface
    //public abstract class BaseEntity
    //{
    //    public int Id { get; set; }
    //}

    //interface IMainOperation
    //{
    //    void Add();
    //    void Delete(int id);
    //    void Update();
    //    void GetAll();
    //}

    //interface IProductCartOperation
    //{
    //    void AddProductToCart();
    //    void DeleteProductFromCart();
    //    void UpdateProductToCart();
    //}

    //class Product : BaseEntity, IMainOperation, IProductCartOperation
    //{
    //    public void Add()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void AddProductToCart()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void DeleteProductFromCart()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UpdateProductToCart()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion


    #region Abstract

    //abstract class Human
    //{
    //    public abstract void Talk();
    //    public abstract void Walk();
    //    public abstract void Add();
    //    public void Test()
    //    {

    //    }
    //}

    //class Student : Human
    //{
    //    public override void Add()
    //    {
    //        // Student bazaya elave olunanda eyni adli studente icaze vere bilirsen
    //    }

    //    public override void Talk()
    //    {
    //        Console.WriteLine("Student Talking");
    //    }

    //    public override void Walk()
    //    {
    //        Console.WriteLine("Student Walking");
    //    }
    //}

    //class Teacher : Human
    //{
    //    public override void Add()
    //    {
    //        //bazaya elave olunanda adlar unique olsun
    //    }

    //    public override void Talk()
    //    {
    //        Console.WriteLine("Teacher Talking");
    //    }

    //    public override void Walk()
    //    {
    //        Console.WriteLine("Teacher Walking");
    //    }
    //}
    #endregion
}
