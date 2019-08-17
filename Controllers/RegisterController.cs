using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aural_api_user.Models;
using Microsoft.AspNetCore.Mvc;
using static aural_model_lib.User.UserApiModel;
namespace aural_api_user.Controllers
{
    /// <summary>
    /// Controller to handle all the registration process made from user. 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        // POST Register User
        [HttpPost]
        public ActionResult<RegisterOutputModel> Post([FromBody] UserApiRegisterModel userApiRegisterModel)
        {
            var res = userApiRegisterModel.ValidationResult();
            if (res == "")
            {
                // No Error
                return Content("No Error");
            }
            else
            {
                return new RegisterOutputModel
                {
                    StatusCode = 1,
                    StatusMessage = "Invalid Format Provided",
                    ErrorMessages = res
                };
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Content("You have entered the registration page");
        }
    }
}
