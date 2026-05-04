using Models;
using Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        if (request.ClienteId <= 0)
            return BadRequest(new { mensagem = "clienteId é obrigatório." });

        if (request.VeiculoId <= 0)
            return BadRequest(new { mensagem = "veiculoId é obrigatório." });

        if (request.Itens == null || request.Itens.Count == 0)
            return BadRequest(new { mensagem = "O orçamento deve possuir pelo menos 1 item." });

        foreach (var item in request.Itens)
        {
            if (string.IsNullOrWhiteSpace(item.Descricao))
                return BadRequest(new { mensagem = "Todos os itens devem possuir descrição." });

            if (item.Quantidade <= 0)
                return BadRequest(new { mensagem = "A quantidade do item deve ser maior que zero." });

            if (item.ValorUnitario <= 0)
                return BadRequest(new { mensagem = "O valor unitário do item deve ser maior que zero." });
        }

        var resultado = _orcamentoService.CriarOrcamento(request);

        return Created("", resultado);
    }
}