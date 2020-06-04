using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ExceptionLogController : ControllerBase {
        private readonly IExceptionLogService exceptionLogService;

        public ExceptionLogController(IExceptionLogService exceptionLogService) {
            this.exceptionLogService = exceptionLogService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Get() {
            try {
                return StatusCode(StatusCodes.Status200OK, this.exceptionLogService.Get());
            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Post(string Message
            , string InnerException
            , string StackTrace
            , DateTime ExceptionDateTime
            , string LogedUser
            , string Note) {
            try {
                this.exceptionLogService.Post(Message
                    , InnerException
                    , StackTrace
                    , ExceptionDateTime
                    , LogedUser
                    , Note);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}