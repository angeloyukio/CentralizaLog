using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class OperationLogController : ControllerBase {
        public readonly IOperationLogService operationLogService;

        public OperationLogController(IOperationLogService operationLogService) {
            this.operationLogService = operationLogService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Get() {
            try {
                return StatusCode(StatusCodes.Status200OK, this.operationLogService.Get());
            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Post(DateTime OperationDateTime
        , string LogedUser
        , string Note) {
            try {
                this.operationLogService.Post(OperationDateTime, LogedUser, Note);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}