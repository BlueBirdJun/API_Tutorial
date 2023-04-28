using Microsoft.AspNetCore.Mvc;

namespace API_Tutorial.Controllers.Base;

[Route("api/[controller]")]
[ApiVersionNeutral]

public class VersionNeutralApiController : BaseApiController
{

}