namespace Models.DTOs;

public class OrcamentoResponse
{
    public int ClienteId { get; set; }
    public int VeiculoId { get; set; }
    public string Status { get; set; } = "Aberto";
    public decimal ValorTotal { get; set; }
    public DateTime DataCriacao { get; set; }
    public List<OrcamentoItemResponse> Itens { get; set; } = new();
}

public class OrcamentoItemResponse
{
    public string Descricao { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal ValorTotal { get; set; }
}