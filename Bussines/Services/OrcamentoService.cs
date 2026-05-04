using Models;
using Bussines.Interfaces;

namespace Bussines.Services;

public class OrcamentoService : IOrcamentoService
{
    public object CriarOrcamento(CriarOrcamentoRequest request)
    {
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