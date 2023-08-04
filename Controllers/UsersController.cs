using foodOrderingSystem.data;
using foodOrderingSystem.DTO_s;
using foodOrderingSystem.MainDTO;
using foodOrderingSystem.models;
using Microsoft.AspNetCore.Mvc;

namespace foodOrderingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly AppDBContext _context;
        public UsersController(AppDBContext context)
        {
            _context = context;
        }

       
        [HttpPost]
        public IActionResult addUser(userDTO userBody)
        {
            var user1 = new Users
            {
                Name = userBody.name
            };

            var product1 = userBody.productDto.Select(p => new Products { Name = p.name, User = user1, OrderDetails = new List<OrderDetails>()
            });


            var productCont = new List<Products>();

            foreach(var p in userBody.productDto)
            {
                var product = new Products
                {
                    Name = p.name,
                    User = user1,
                    OrderDetails = new List<OrderDetails>
                    {
                        new OrderDetails
                        {
                            Users = user1
                        }
                    }
                } 
            }

           // var orderDetails1 = product1.Select(o => new OrderDetails { Users = user1 });
            

            
            user1.Products = product1.ToList();
            
        

            _context.user.Add(user1);
            _context.SaveChanges();
                
                return Ok(_context.user.ToList());
        }





    }
}
