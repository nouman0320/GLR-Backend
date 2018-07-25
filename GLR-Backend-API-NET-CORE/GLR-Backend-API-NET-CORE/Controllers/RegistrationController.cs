using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit

namespace GLR_Backend_API_NET_CORE.Controllers
{

    
    public class RegistrationController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public bool Login([FromBody] User user)
        {
            if (user.Email.Equals("usman") && user.Password.Equals("usman"))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
