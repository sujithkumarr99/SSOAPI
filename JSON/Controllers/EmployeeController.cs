
using JSON.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JSON.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]

        public string GetData()
        {
            return "Executed Using Json Token";
        }

        [HttpGet]
        [Route("Details")]

        public string Details()
        {
            return "Executed Using Json Token";
        }

        [Authorize]
        [HttpPost]
        [Route("Details")]

        public string AddUser(Users user)
        {
            return "User added with username" + user.Username;
        }
    }
}
