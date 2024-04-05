using iTEC_Hackathon.DTOs;
using iTEC_Hackathon.Interfaces;
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
        public async Task<IActionResult> LoginUserAsync([FromBody] UserCredentialsLoginDTO userCredentialsDTO)
        {
            var userID = await _loginUserRepository.LoginUserAsyncRepo(userCredentialsDTO);

            if (userID > 0)
                return Ok(userID);
            else
                return BadRequest("Login failed.");
        }

        [HttpPost]
        [Route("RegisterUser")]
        public async Task<IActionResult> RegisterUserAsync([FromBody] UserCredentialsRegisterDTO userCredentialsRegisterDTO)
        {
            var userID = await _registerUserRepository.RegisterUserAsyncRepo(userCredentialsRegisterDTO);

            if (userID > 0)
                return Ok(userID);
            else
                return BadRequest("Registration failed.");
        }

    }
}
