using iTEC_Hackathon.DTOs;
using iTEC_Hackathon.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace iTEC_Hackathon.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly ILoginUserRepository _loginUserRepository;

        public UserController(ILoginUserRepository loginUserRepository)
        {
            _loginUserRepository = loginUserRepository;
        }

        [HttpPost]
        [Route("LoginUser")]
        public async Task<IActionResult> LoginUserAsync([FromBody] UserCredentialsDTO userCredentialsDTO)
        {
            var userID = await _loginUserRepository.LoginUserAsyncRepo(userCredentialsDTO);

            if (userID != null)
                return Ok(userID);
            else
                return BadRequest("Login failed.");
        }
    }
}
