using TorneSe.ServicoNotaAlunos.Domain.Messages;

namespace TorneSe.ServicoNotaAlunos.Application.Interfaces;

public interface IServicoAplicacaoNotaAluno
{
    Task ProcessarLancamentoNota(RegistrarNotaAluno registrarNotaAluno);
}
