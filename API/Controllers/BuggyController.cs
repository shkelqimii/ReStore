using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class BuggyController : ControllerBase
    {
        [HttpGet("not-found")] 
        public ActionResult GetNotFound()
        {
            return NotFound(); 
        }

        [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ProblemDetails{ Title = "this is a bad request"}); 
        }

        [HttpGet("unauthorized")]
        public ActionResult GetUnauthorized()
        {
            return Unauthorized(); 
        }

        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("problem1", "this is the first error");
            ModelState.AddModelError("problem2", "this is the secondary error");
            return ValidationProblem();
        }

        [HttpGet("server-error")]
        public ActionResult GetServerError()
        {
            throw new Exception("this is a server error");
        }
    }
}
