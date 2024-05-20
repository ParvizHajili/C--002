using SOLID.Repositories;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IRepository repository = new OracleRepository();

            repository.Add();

            //builder.services.addscoped<IRepository, SqlRepository>();
            //builder.services.addscoped<IRepository, Oracle>();
            //OracleRepository sqlRepository = new OracleRepository();
            //sqlRepository.Add();


            //OracleRepository sqlRepository2 = new OracleRepository();
            //sqlRepository2.Update();
        }
    }
}
