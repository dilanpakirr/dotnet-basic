
using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers
{
    public class ProductsController : Controller
    {
        //localhost:5255 products
        public ActionResult Index()
        {
            return View();
        }

        //localhost:5255 products/details
        public ActionResult Details()

        {
            //   string name="Laptop";
            //     double price=50000;
            //     string description="This is a laptop";
            //     bool productStatus=true;
            //     ViewData["ProductName"]=name;
            //     ViewData["ProductPrice"]=price;
            //     ViewData["ProductDescription"]=description;
            //     ViewData["ProductStatus"]=productStatus;
            Product product = new Product();
            product.productName = "Laptop";
            product.productDescription = "This is a laptop";
            product.productPrice = 50000;
            product.productStatus = true;

            return View(product);
        }

        //localhost:5255/products/list
        public ActionResult List()
        {
            List<Product> products = new List<Product> {
                new Product { productName = "Laptop", productDescription = "This is a laptop", productPrice = 50000, productStatus = true },
                new Product { productName = "Mobile", productDescription = "This is a mobile", productPrice = 20000, productStatus = true },
                new Product { productName = "Tablet", productDescription = "This is a tablet", productPrice = 15000, productStatus = false }
            };
            return View(products);
        }

    }
}