using System.ComponentModel;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hyundai hyundai = new Hyundai();
            Hyundai hyundai1 = new Hyundai();
            Hyundai hyundai2 = new Hyundai();

            List<Kia> kias = new List<Kia>();
            List<Bmw> bmws = new List<Bmw>();

            //restriction

            //CarSellOperation<Kia,Bmw> carSellOperation = new CarSellOperation<Kia,Bmw>();
            //carSellOperation.AddRange<Kia,Bmw>(kias,bmws);
            //CarSellOperation<Hyundai> hyundaiCar = new CarSellOperation<Hyundai>();
            //hyundaiCar.AddRange(hyundai, hyundai, hyundai2); 

            //CarSellOperation<Kia> kiaCar = new();
            //kiaCar.Add(kia);


            //CarSellOperation<Bmw> operation = new CarSellOperation<Bmw>();
            //Test<int> test = new Test<int>();
            //t.Sum(hyundai,hyundai2,hyundai1);

            CarSellOperation<Hyundai> carSellOperation = new CarSellOperation<Hyundai>();

        }
    }

    //public class Product<T> 
    //{

    //}

    //public class Category <T> :Product<int>
    //{

    //}

    public class CarSellOperation<T>
        where T : class, ICar, new()
    {
        private T[] cars = new T[100];
        public int count = 0;
        public void Add(T car)
        {
            cars[count++] = car;
        }

        public void AddRange<T1>(params T[] values)
        {
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    cars[count++] = cars[i];
            //}
        }
    }

    public interface ICar
    {
        void Drive();
    }

    public class Hyundai : ICar
    {
        //public Hyundai(int a)
        //{
            
        //}
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class Kia : ICar
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class Bmw : ICar
    {
        //public Bmw(int a)
        //{

        //}
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }


    public class Test<T> where T : struct
    {
        //public void Sum(int a,int b,int c)
        //{
        //    Console.WriteLine("Sum numbers");
        //}

        public void Sum<T>(T a, T b, T c)
        {
            Console.WriteLine("Sum numbers");
        }
    }

}
