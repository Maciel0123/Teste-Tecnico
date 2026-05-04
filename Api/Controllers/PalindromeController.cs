using Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PalindromeController : ControllerBase
{
    private readonly IPalindromeService _palindromeService;

    public PalindromeController(IPalindromeService palindromeService)
    {
        _palindromeService = palindromeService;
    }

    [HttpGet("check")]
    public IActionResult Check([FromQuery] string text)
    {
        bool result = _palindromeService.IsPalindrome(text);

        return Ok(new
        {
            input = text,
            isPalindrome = result
        });
    }
}