using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorGastos.DAL.Models;

public class PessoaItem
{

    [Column("pessoa_nome")]
    public string PessoaNome { get; set; }
    
    [Column("nome_item")]
    public string NomeItem { get; set; }

    [Column("valor_item")]
    public decimal ValorItem { get; set; }
    
    [Column("data_cadastro")]
    public DateTime DataCadastro { get; set; }

}
