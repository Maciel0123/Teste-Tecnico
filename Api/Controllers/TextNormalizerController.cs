using Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TextNormalizerController : ControllerBase
{
    private readonly ITextNormalizerService _textNormalizerService;

    public TextNormalizerController(ITextNormalizerService textNormalizerService)
    {
        _textNormalizerService = textNormalizerService;
    }

    [HttpGet("normalize")]
    public IActionResult Normalize([FromQuery] string text)
    {
        string result = _textNormalizerService.NormalizeShoutedText(text);

        return Ok(new
        {
            input = text,
            normalized = result
        });
    }
}