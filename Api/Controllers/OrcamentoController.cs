using Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrcamentoController : ControllerBase
{
    private readonly IOrcamentoService _orcamentoService;

    public OrcamentoController(IOrcamentoService orcamentoService)
    {
        _orcamentoService = orcamentoService;
    }

    [HttpPost]
    public IActionResult Criar([FromBody] CriarOrcamentoRequest request)
    {
        try
        {
            var resultado = _orcamentoService.CriarOrcamento(request);
            return Created("", resultado);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { mensagem = ex.Message });
        }
    }
}