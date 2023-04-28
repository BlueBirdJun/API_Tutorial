using API_Tutorial.Controllers.Base;

namespace API_Tutorial.Controllers;

public class BoardNoverController: VersionNeutralApiController
{
    [HttpGet]
    [Route("t1")]
    [AllowAnonymous]
    public async Task<IActionResult> Get1()
    {
        return Ok("Hello world");
    }
}
