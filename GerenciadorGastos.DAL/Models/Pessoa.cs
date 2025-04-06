using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorGastos.DAL.Models;

public class Pessoa
{
    [Key]
    [Column("pessoa_Id")]  
    public int PessoaId { get; set; }

    [Column("pessoa_nome")]  
    public string PessoaNome { get; set; }

    [Column("data_cadastro")]  
    public DateTime DataCadastroPessoa { get; set; }
}
