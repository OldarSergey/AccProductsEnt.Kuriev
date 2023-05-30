using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IProductService
    {
        public void AddProduct (Product newProduct);

        public void RemoveProduct (string productName);

        public void UpdateProduct (string productName,Product newProduct);

        public Product GetProduct (string productName);
    }
}
