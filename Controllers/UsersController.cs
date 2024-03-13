using Ecommerce.Data.Abstract;
using Ecommerce.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private UserManager<User> _userManager;
        public UsersController(IUserRepository userRepository, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }
        public async Task<IActionResult> Profile(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return NotFound();
            }

            var user = await _userManager
                        .Users
                        .Include(x => x.Products)
                        .Include(x => x.Comments)
                        .ThenInclude(x => x.Product)
                        .FirstOrDefaultAsync(x => x.UserName == name);
            if (user == null)
            {
                return BadRequest();
            }
            
            return View(user);
        }

        
    }
}
