namespace API_Tutorial.Controllers.Base;

[Route("api/v{version:apiVersion}/[controller]")]
public class VersionedApiController : BaseApiController
{
}
