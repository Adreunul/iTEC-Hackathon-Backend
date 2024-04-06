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
        private readonly IGetUserApplicationsInfoRepository _getUserApplicationsInfoRepository;

        public UserController(ILoginUserRepository loginUserRepository, 
            IRegisterUserRepository registerUserRepository, 
            IGetUserApplicationsInfoRepository getUserApplicationsInfoRepository)
        {
            _loginUserRepository = loginUserRepository;
            _registerUserRepository = registerUserRepository;
            _getUserApplicationsInfoRepository = getUserApplicationsInfoRepository;
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

        [HttpGet]
        [Route("GetUserApplicationsInfo")]
        public async Task<IActionResult> GetUserApplicationsInfoAsync( int idUser)
        {
            var userApplicationsInfo = await _getUserApplicationsInfoRepository.GetUserApplicationsInfoAsyncRepo(idUser);

            if (userApplicationsInfo != null)
                return Ok(userApplicationsInfo);
            else
                return BadRequest("No applications found.");
        }
    }
}
