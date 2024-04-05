﻿using Microsoft.AspNetCore.Mvc;
using iTEC_Hackathon.Interfaces;
using iTEC_Hackathon.DTOs.Application;

namespace iTEC_Hackathon.Controllers
{
    public class ApplicationController : ControllerBase
    {
        private readonly IAddApplicationRepository _addApplicationRepository;
        private readonly IDeleteApplicationRepository _deleteApplicationRepository;
        private readonly IGetApplicationRepository _getApplicationRepository;

        public ApplicationController(IAddApplicationRepository addApplicationRepository,
            IDeleteApplicationRepository deleteApplicationRepository, 
            IGetApplicationRepository getApplicationRepository)
        {
            _addApplicationRepository = addApplicationRepository;
            _deleteApplicationRepository = deleteApplicationRepository;
            _getApplicationRepository = getApplicationRepository;
        }

        [HttpPost]
        [Route("AddApplication")]
        public async Task<IActionResult> AddApplicationAsync([FromBody] ApplicationInsertDTO applicationInsertDTO)
        {
            var applicationID = await _addApplicationRepository.AddApplicationAsyncRepo(applicationInsertDTO);

            if (applicationID > 0)
                return Ok(applicationID);
            else
                return BadRequest("Application failed.");
        }

        [HttpDelete]
        [Route("DeleteApplication")]
        public async Task<IActionResult> DeleteApplicationAsync([FromBody] int idApplication)
        {
            var success = await _deleteApplicationRepository.DeleteApplicationAsyncRepo(idApplication);

            if (success == 1)
                return Ok(success);
            else
                return BadRequest("Application failed.");
        }

        [HttpGet]
        [Route("GetApplication(s)")]
        public async Task<IActionResult> GetApplicationAsync(int idUserAuthor)
        {
            var result = await _getApplicationRepository.GetApplicationAsyncRepo(idUserAuthor);

            if (result != null)
                return Ok(result);
            else
                return BadRequest("Application failed.");
        }
    }
}
