namespace CarProject
{
    public interface ICarOperation :IBaseOperation<Car>
    {
        List<Car> GetAllCarBrand(string brand);
        void PlayRadio();
        void PlayHorn();
    }
}
