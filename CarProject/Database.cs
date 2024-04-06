namespace CarProject
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    public class Database
    {
        private static Database _instance;
        public static Database Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Database();
                return _instance;
            }
        }

        private Database()
        {

        }


        public List<Car> Cars = new List<Car>()
        {
            //new Car{Brand="BMW",Model="F30",Year=2015},
            //new Car{Brand="Mercedes",Model="E220",Year=2008},
            //new Car{Brand="Hyundai",Model="Tucson",Year=2017},
        };
    }
}
