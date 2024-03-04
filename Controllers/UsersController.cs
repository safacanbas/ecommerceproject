using Ecommerce.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IActionResult> Profile(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return NotFound();
            }

            var user = await _userRepository
                        .Users
                        .Include(x => x.Products)
                        .Include(x => x.Comments)
                        .ThenInclude(x => x.Product)
                        .FirstOrDefaultAsync(x => x.Name == name);
            if (user == null)
            {
                return BadRequest();
            }
            
            return View(user);
        }

        
    }
}
