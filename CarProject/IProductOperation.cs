namespace CarProject
{
    public interface IProductOperation : IBaseOperation<Product>
    {
        Product GetProductWithCategory(string categoryName);
    }
}
