using TorneSe.ServicoNotaAlunos.Application.Interfaces;
using TorneSe.ServicoNotaAlunos.Domain.Excecoes;
using TorneSe.ServicoNotaAlunos.Domain.Interfaces.Services;
using TorneSe.ServicoNotaAlunos.Domain.Messages;

namespace TorneSe.ServicoNotaAlunos.Application.Services;

public class ServicoAplicacaoNotaAluno : IServicoAplicacaoNotaAluno
{
    private readonly IServicoNotaAluno _servicoNotaAluno;
    public ServicoAplicacaoNotaAluno(IServicoNotaAluno servicoNotaAluno)
    {
        _servicoNotaAluno = servicoNotaAluno;
    }

    public async Task ProcessarLancamentoNota(RegistrarNotaAluno registrarNotaAluno)
    {
        try
        {
            Console.WriteLine("Orquestrando o fluxo da aplicação");
            await _servicoNotaAluno.LancarNota(registrarNotaAluno);
        }
        catch(DomainException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
