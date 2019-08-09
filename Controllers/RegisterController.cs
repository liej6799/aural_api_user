using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aural_api_user.Models;
using Microsoft.AspNetCore.Mvc;

namespace aural_api_user.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        // POST Register User
        [HttpPost]
        public void Post([FromBody] UserModel userModel)
        {
            var a = userModel; 
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "You have entered the register section.";
        }
    }
}
