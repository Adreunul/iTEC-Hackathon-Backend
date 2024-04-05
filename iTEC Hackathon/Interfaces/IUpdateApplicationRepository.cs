using iTEC_Hackathon.DTOs.Application;

namespace iTEC_Hackathon.Interfaces
{
    public interface IUpdateApplicationRepository
    {
        Task<int> UpdateApplicationAsyncRepo(ApplicationUpdateDTO applicationUpdateDTO);
    }
}