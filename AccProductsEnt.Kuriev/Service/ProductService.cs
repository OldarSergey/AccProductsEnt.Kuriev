using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class  ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
              _context = context;
        }
        public void AddProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

        public Product GetProduct(string productName)
        {
            return _context.Products
                .Where(product => product.ProductName == productName && product.IsDeleted == false)
                .FirstOrDefault();
        }

        public void RemoveProduct(string productName)
        {
            var products = _context.Products
                .Where(product => product.ProductName == productName)
                .FirstOrDefault();
            products.IsDeleted = true;
            _context.SaveChanges();
        }

        public void UpdateProduct(string productName, Product newProduct) 
        {
            var products = _context.Products
                .Where(product => product.ProductName == productName)
                .FirstOrDefault();
            products = newProduct;
            _context.SaveChanges();
        }
    }
}
