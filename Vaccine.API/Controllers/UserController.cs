using Microsoft.AspNetCore.Mvc;
using Vaccine.Core.OutputModel;

namespace Vaccine.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        [HttpGet]
        public UserOutputModel Get()
        {
            return new UserOutputModel()
            {
                Name = "Chelovek",
                Role = Core.UserRole.Patient
            };
        }
    }
}
