using Microsoft.AspNetCore.Mvc;
using iTEC_Hackathon.Interfaces;

namespace iTEC_Hackathon.Controllers
{
    public class StatisticsController : ControllerBase
    {
        private readonly IGetTotalNumbersOfRecordsRepository _getTotalNumbersOfRecordsRepository;
        private readonly IGetTotalNumberOfEndpointsByStateRepository _getTotalNumberOfEndpointsByStateRepository;
        public StatisticsController(IGetTotalNumbersOfRecordsRepository getTotalNumbersOfRecordsRepository,
            IGetTotalNumberOfEndpointsByStateRepository getTotalNumberOfEndpointsByStateRepository)
        {
            _getTotalNumbersOfRecordsRepository = getTotalNumbersOfRecordsRepository;
            _getTotalNumberOfEndpointsByStateRepository = getTotalNumberOfEndpointsByStateRepository;
        }

        [HttpGet]
        [Route("GetTotalNumberOfRecords")]
        public async Task<IActionResult> GetStatisticsAsyncRepo()
        { 
            var result = await _getTotalNumbersOfRecordsRepository.GetTotalNumbersOfRecordsAsyncRepo();

            if (result != null)
                return Ok(result);
            else
                return BadRequest("Statistics failed.");
        }

        [HttpGet]
        [Route("GetTotalNumberOfEndpointsByState")]
        public async Task<IActionResult> GetTotalNumberOfEndpointsByStateAsyncRepo()
        {
            var result = await _getTotalNumberOfEndpointsByStateRepository.GetTotalNumberOfEndpointsByStateAsyncRepo();

            if (result != null)
                return Ok(result);
            else
                return BadRequest("Statistics failed.");
        }
    }
}
