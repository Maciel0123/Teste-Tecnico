using Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FibonacciController : ControllerBase
{
    private readonly IFibonacciService _fibonacciService;

    public FibonacciController(IFibonacciService fibonacciService)
    {
        _fibonacciService = fibonacciService;
    }

    [HttpGet]
    public IActionResult Get([FromQuery] int count)
    {
        var result = _fibonacciService.Generate(count);

        return Ok(new
        {
            count,
            sequence = result
        });
    }
}