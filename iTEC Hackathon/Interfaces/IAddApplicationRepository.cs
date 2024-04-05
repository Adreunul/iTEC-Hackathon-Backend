using iTEC_Hackathon.DTOs.Application;

namespace iTEC_Hackathon.Interfaces
{
    public interface IAddApplicationRepository
    {
        Task<int> AddApplicationAsyncRepo(ApplicationInsertDTO applicationInsertDTO);
    }
}