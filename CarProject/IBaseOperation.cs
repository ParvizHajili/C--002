namespace CarProject
{
    public interface IBaseOperation <T> where T : class
    {
        void Add(T t);
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
