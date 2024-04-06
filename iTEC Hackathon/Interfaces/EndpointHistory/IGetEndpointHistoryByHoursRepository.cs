using iTEC_Hackathon.DTOs.EndpointHistory;

namespace iTEC_Hackathon.Interfaces.EndpointHistory
{
    public interface IGetEndpointHistoryByHoursRepository
    {
        Task<IEnumerable<EndpointHistoryGetByHoursDTO>> GetEndpointHistoryByHoursAsync(int idEndpoint, int hours);
    }
}