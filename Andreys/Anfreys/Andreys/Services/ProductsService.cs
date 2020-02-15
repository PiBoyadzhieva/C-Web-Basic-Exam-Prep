using System;
using Andreys.Data;
using Andreys.Models;
using Andreys.ViewModels.Products;

namespace Andreys.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AndreysDbContext db;

        public ProductsService(AndreysDbContext db)
        {
            this.db = db;
        }
        public int Add(AddProductInputModel productInputModel)
        {
            var genderAsEnum = Enum.Parse<ProductGender>(productInputModel.Gender);
            var categoryAsEnum = Enum.Parse<ProductCategory>(productInputModel.Category);

            var product = new Product
            {
                Name = productInputModel.Name,
                Description = productInputModel.Description,
                ImageUrl = productInputModel.ImageUrl,
                Category = categoryAsEnum,
                Gender = genderAsEnum
            };

            this.db.Products.Add(product);
            this.db.SaveChanges();

            return product.Id;
        }
    }
}
