using Models;

namespace Bussines.Interfaces;

public interface IOrcamentoService
{
    object CriarOrcamento(CriarOrcamentoRequest request);
}