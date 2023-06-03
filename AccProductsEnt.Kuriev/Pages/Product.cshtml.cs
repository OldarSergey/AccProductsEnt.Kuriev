using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Entities.DTO;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProductsEnt.Kuriev.Pages
{
    public class ProductModel : PageModel
    {

        private readonly IProductService _productService;

        [BindProperty]
        public IEnumerable<Product> Products { get; set; }
        [BindProperty]
        public InputProduct Input { get; set; }
        public ProductModel(IProductService productService)
        {
            _productService = productService;   
        }
        public void OnGet()
        {
            Products = _productService.GetAllProducts();
        }

        public IActionResult OnPost()
        {
            var product = new Product
            {
                Description = Input.Description,
                ProductName = Input.ProductName,
                Quantity = Input.Quantity,
                DateOfManufacture = Input.DateOfManufacture,
                PricePerPiece = Input.PricePerPiece,
                ImgPath = Input.ImgPath,
                WorkshopId = -1// Недопустимое значение
                StorageId = -1, // Недопустимое значение
                AccountingId = -1, // Недопустимое значение
                ImplementationId = -1 // Недопустимое значение
            };


            _productService.AddProduct(product);
            return Page();
        }
    }

}
