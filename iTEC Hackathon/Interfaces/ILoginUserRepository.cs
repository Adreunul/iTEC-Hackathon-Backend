using iTEC_Hackathon.DTOs.User;

namespace iTEC_Hackathon.Interfaces
{
    public interface ILoginUserRepository
    {
        Task<int> LoginUserAsyncRepo(UserCredentialsDTO userCredentialsDTO);
    }
}