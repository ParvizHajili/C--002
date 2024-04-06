namespace CarProject
{
    public interface ICarOperation
    {
        void Add(Car car);
        void Delete(int id);
        Car GetById(int id);
        List<Car> GetAllCarBrand(string brand);
        List<Car> GetAllCars();
        void PlayRadio();
        void PlayHorn();
    }
}
