using Models.DTOs;

namespace Bussines.Interfaces;

public interface IOrcamentoService
{
    object CriarOrcamento(CriarOrcamentoRequest request);
}