using iTEC_Hackathon.DTOs;

namespace iTEC_Hackathon.Interfaces
{
    public interface ILoginUserRepository
    {
        Task<int> LoginUserAsyncRepo(UserCredentialsLoginDTO userCredentialsDTO);
    }
}