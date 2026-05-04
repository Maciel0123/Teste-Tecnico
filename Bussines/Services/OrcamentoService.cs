using Models.DTOs;
using Bussines.Interfaces;

namespace Bussines.Services;

public class OrcamentoService : IOrcamentoService
{
    public object CriarOrcamento(CriarOrcamentoRequest request)
    {
        if (request.ClienteId <= 0)
            throw new ArgumentException("clienteId é obrigatório.");

        if (request.VeiculoId <= 0)
            throw new ArgumentException("veiculoId é obrigatório.");

        if (request.Itens == null || request.Itens.Count == 0)
            throw new ArgumentException("O orçamento deve possuir pelo menos 1 item.");

        foreach (var item in request.Itens)
        {
            if (string.IsNullOrWhiteSpace(item.Descricao))
                throw new ArgumentException("Todos os itens devem possuir descrição.");

            if (item.Quantidade <= 0)
                throw new ArgumentException("A quantidade do item deve ser maior que zero.");

            if (item.ValorUnitario <= 0)
                throw new ArgumentException("O valor unitário do item deve ser maior que zero.");
        }

        decimal valorTotal = request.Itens.Sum(item => item.Quantidade * item.ValorUnitario);

        return new
        {
            clienteId = request.ClienteId,
            veiculoId = request.VeiculoId,
            status = "Aberto",
            valorTotal,
            dataCriacao = DateTime.Now,
            itens = request.Itens.Select(item => new
            {
                item.Descricao,
                item.Quantidade,
                item.ValorUnitario,
                valorTotal = item.Quantidade * item.ValorUnitario
            })
        };
    }
}