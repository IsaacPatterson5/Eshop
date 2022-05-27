using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
       [HttpGet("not-found")]
       public ActionResult GetNotFound()
       {
           return NotFound();
       }

       [HttpGet("not-found")]
       public ActionResult GetBadRequest()
       {
           return BadRequest("This is a bad request");
       }

       [HttpGet("not-found")]
       public ActionResult GetUnauthorized()
       {
           return Unauthorized();
       }

       [HttpGet("not-found")]
       public ActionResult GetValidationError()
       {
           ModelState.AddModelError("Problem1", "This is the first error");
           ModelState.AddModelError("Problem1", "This is the second error");
           return ValidationProblem();
       }

       [HttpGet("not-found")]
       public ActionResult GetServerError()
       {
           throw new Exception("This is a server error");
       } 
    }
}