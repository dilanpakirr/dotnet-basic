
using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers
{
    public class Products : Controller
    {

        List<Product> products = new List<Product> {
                new Product {id=1, productName = "Laptop", productDescription = "This is a laptop", productPrice = 50000, productStatus = true },
                new Product { id=2,productName = "Mobile", productDescription = "This is a mobile", productPrice = 20000, productStatus = true },
                new Product {id=3, productName = "Tablet", productDescription = "This is a tablet", productPrice = 15000, productStatus = false }
            };
        //localhost:5255 products
        public ActionResult Index()
        {
            List<Product> product = products.Where(p => p.productStatus).ToList();
            return View(product);
        }

        //localhost:5255 products/details
        public ActionResult Details(int id)

        {
            //   string name="Laptop";
            //     double price=50000;
            //     string description="This is a laptop";
            //     bool productStatus=true;
            //     ViewData["ProductName"]=name;
            //     ViewData["ProductPrice"]=price;
            //     ViewData["ProductDescription"]=description;
            //     ViewData["ProductStatus"]=productStatus;
            // Product product = new Product();
            // product.productName = "Laptop";
            // product.productDescription = "This is a laptop";
            // product.productPrice = 50000;
            // product.productStatus = true;
            Product? product = products.Where(p => p.id == id).FirstOrDefault();
            return View(product);

        }

        //localhost:5255/products/list
        public ActionResult List()
        {
            return View(products);
        }

    }
}