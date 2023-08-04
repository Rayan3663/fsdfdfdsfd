using foodOrderingSystem.MainDTO;
using foodOrderingSystem.models;
using Microsoft.AspNetCore.Mvc;

namespace foodOrderingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {

        [HttpPost]
        public IActionResult getProducts(productDTO productsBody)
        {
            var product1 = new Products
            {
                Name = productsBody.name,
            };


            return View();
        }
    }
}
