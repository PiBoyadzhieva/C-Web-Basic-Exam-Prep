using Andreys.ViewModels.Products;

namespace Andreys.Services
{
    public interface IProductsService
    {
        int Add(AddProductInputModel product);

        //or
        //int Add(string Name, string Description, string ImageUrl, string Category, string Gender, decimal Price);
    }
}
