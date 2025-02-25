using System;
using TorneSe.ServicoNotaAlunos.Domain.ValueObjects;
using TorneSe.ServicoNotaAlunos.Domain.DomainObjects;

namespace TorneSe.ServicoNotaAlunos.Domain.Entidades;

public class Usuario : Entidade, IRaizAgregacao
{
    public Usuario(string nome, string documentoIdentificacao, DateTime dataNascimento, bool ativo, string email, Telefone telefoneContato, bool administrativo, DateTime dataCadastro)
    {
        Nome = nome;
        DocumentoIdentificacao = documentoIdentificacao;
        DataNascimento = dataNascimento;
        Ativo = ativo;
        Email = email;
        TelefoneContato = telefoneContato;
        Administrativo = administrativo;
        DataCadastro = dataCadastro;
    }

    protected Usuario() { }

    public string Nome { get; private set; }
    public string DocumentoIdentificacao { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public bool Ativo { get;  private set;}
    public string Email { get; private set; }
    public Telefone TelefoneContato { get; private set; }
    public bool Administrativo { get; private set; }
    public DateTime DataCadastro { get; private set; }

    public Aluno Aluno { get; private set; }
    public Professor Professor { get; private set; }
}
