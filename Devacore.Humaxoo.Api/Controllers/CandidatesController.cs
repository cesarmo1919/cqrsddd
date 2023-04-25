using Microsoft.AspNetCore.Mvc;

namespace Devacore.Humaxoo.Api.Controllers;

[Route("/api/[controller]")]
public class CandidatesController : ApiController
{

    [HttpGet]
    public IActionResult ListCandidates()
    {
        return Ok(Array.Empty<string>());
    }
}