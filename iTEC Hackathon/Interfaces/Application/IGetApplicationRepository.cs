using iTEC_Hackathon.DTOs.Application;

namespace iTEC_Hackathon.Interfaces.Application
{
    public interface IGetApplicationRepository
    {
        Task<IEnumerable<ApplicationGetDTO>> GetApplicationAsyncRepo(int idUserAuthor);
    }
}