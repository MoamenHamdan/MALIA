using Microsoft.AspNetCore.Mvc;
using M_Suite.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;
using M_Suite.Context;

namespace M_Suite.Controllers
{
    public class UserController : Controller
    {
        private readonly MaliaContext _context;
     

        public UserController(MaliaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        //private bool VerifyPassword(string inputPassword, string storedPassword)
        //{
        //    return BCrypt.Net.BCrypt.Verify(inputPassword, storedPassword);
        //}


        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UsLogin == username);
            if (user == null || user.UsPassword != password) 
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }


            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UsLogin),
                new Claim("FullName", $"{user.UsFirstName} {user.UsLastName}"),
               new Claim(ClaimTypes.Role, user.UsType ?? string.Empty)

            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties();

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);


            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");

        }
    }
}
