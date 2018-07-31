using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GLR_Backend_API_NET_CORE.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using GLR_Backend_API_NET_CORE.Models;
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
        public bool Login([FromBody] UserInfo userInfo)
        {
            return RegistrationService.login(userInfo);
        }
        [HttpPost]
        public bool register([FromBody] GLR_Backend_API_NET_CORE.Models.UserInfo userInfo)
        {
             
            return RegistrationService.register(userInfo);
        }
    }
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
