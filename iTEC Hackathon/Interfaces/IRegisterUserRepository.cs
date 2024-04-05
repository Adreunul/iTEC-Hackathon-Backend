using iTEC_Hackathon.DTOs;

namespace iTEC_Hackathon.Interfaces
{
    public interface IRegisterUserRepository
    {
        Task<int> RegisterUserAsyncRepo(UserCredentialsRegisterDTO userCredentialsRegisterDTO);
    }
}