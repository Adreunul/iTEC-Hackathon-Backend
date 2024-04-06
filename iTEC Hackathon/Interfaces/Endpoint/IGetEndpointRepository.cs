using iTEC_Hackathon.DTOs.Endpoint;
using iTEC_Hackathon.DTOs.EndpointHistory;

namespace iTEC_Hackathon.Interfaces.Endpoint
{
    public interface IGetEndpointRepository
    {
        Task<IEnumerable<EndpointHistoryGetEndpointsStateDTO>> GetEndpointAsyncRepo(int idApplication);
    }
}