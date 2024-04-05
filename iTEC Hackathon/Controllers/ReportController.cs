using Microsoft.AspNetCore.Mvc;
using iTEC_Hackathon.DTOs.Report;
using iTEC_Hackathon.Interfaces.Report;

namespace iTEC_Hackathon.Controllers
{
    public class ReportController : ControllerBase
    {
        private readonly IAddReportRepository _addReportRepository;
        private readonly IGetReportRepository _getReportRepository;
        private readonly IDeleteReportRepository _deleteReportRepository;

        public ReportController(IAddReportRepository addReportRepository,
            IGetReportRepository getReportRepository,
            IDeleteReportRepository deleteReportRepository)
        {
            _addReportRepository = addReportRepository;
            _getReportRepository = getReportRepository;
            _deleteReportRepository = deleteReportRepository;
        }

        [HttpPost]
        [Route("AddReport")]
        public async Task<IActionResult> AddReportAsyncRepo([FromBody] ReportInsertDTO reportInsertDTO)
        {
            var reportID = await _addReportRepository.AddReportAsyncRepo(reportInsertDTO);

            if (reportID > 0)
                return Ok(reportID);
            else
                return BadRequest("Report failed.");
        }

        [HttpGet]
        [Route("GetReport")]
        public async Task<IActionResult> GetReportAsyncRepo(int idApplication)
        {
            var result = await _getReportRepository.GetReportAsyncRepo(idApplication);

            if(result != null)
                return Ok(result);
            else
                return BadRequest("Report failed.");
        }

        [HttpDelete]
        [Route("DeleteReport")]
        public async Task<IActionResult> DeleteReportAsyncRepo([FromBody] int idReport)
        {
            var success = await _deleteReportRepository.DeleteReportAsyncRepo(idReport);

            if (success == 1)
                return Ok(success);
            else
                return BadRequest("Report failed.");
        }
    }
}
