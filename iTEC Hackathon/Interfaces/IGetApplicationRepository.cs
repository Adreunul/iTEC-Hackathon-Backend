using iTEC_Hackathon.DTOs.Application;

namespace iTEC_Hackathon.Interfaces
{
    public interface IGetApplicationRepository
    {
        Task<IEnumerable<ApplicationGetDTO>> GetApplicationAsyncRepo(int idUserAuthor);
    }
}