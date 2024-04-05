﻿using iTEC_Hackathon.DTOs.Endpoint;

namespace iTEC_Hackathon.Interfaces.Endpoint
{
    public interface IGetEndpointRepository
    {
        Task<IEnumerable<EndpointGetDTO>> GetEndpointAsyncRepo(int idApplication);
    }
}