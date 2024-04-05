using iTEC_Hackathon.DTOs.User;
using iTEC_Hackathon.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace iTEC_Hackathon.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly ILoginUserRepository _loginUserRepository;
        private readonly IRegisterUserRepository _registerUserRepository;

        public UserController(ILoginUserRepository loginUserRepository, 
            IRegisterUserRepository registerUserRepository)
        {
            _loginUserRepository = loginUserRepository;
            _registerUserRepository = registerUserRepository;
        }

        [HttpPost]
        [Route("LoginUser")]
        public async Task<IActionResult> LoginUserAsync([FromBody] UserCredentialsDTO userCredentialsDTO)
        {
            var userID = await _loginUserRepository.LoginUserAsyncRepo(userCredentialsDTO);

            if (userID > 0)
                return Ok(userID);
            else
                return BadRequest("Login failed.");
        }

        [HttpPost]
        [Route("RegisterUser")]
        public async Task<IActionResult> RegisterUserAsync([FromBody] UserCredentialsDTO userCredentialsDTO)
        {
            var userID = await _registerUserRepository.RegisterUserAsyncRepo(userCredentialsDTO);

            if (userID > 0)
                return Ok(userID);
            else
                return BadRequest("Registration failed.");
        }

    }
}
