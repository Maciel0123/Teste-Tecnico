namespace Models;

public class CriarOrcamentoRequest
{
    public int ClienteId { get; set; }
    public int VeiculoId { get; set; }
    public List<CriarOrcamentoItemRequest> Itens { get; set; } = new();
}

public class CriarOrcamentoItemRequest
{
    public string Descricao { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
}