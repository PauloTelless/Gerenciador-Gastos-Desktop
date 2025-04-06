using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorGastos.DAL.Models;

public class Item
{
    [Key]
    public int ItemId { get; set; }

    [Column("nome_item")]
    public string NomeItem { get; set; }

    [Column("data_cadastro")]
    public DateTime DataCadastroItem { get; set; } 

    [Column("valor_item")]
    public decimal ValorItem { get; set; }

    [Column("pessoa_nome")]
    public string PessoaNome { get; set; }  
    
    [Column("pago")]
    public bool Pago { get; set; }  

    [ForeignKey("pessoa_id")]
    public int PessoaId { get; set; }

    public override string ToString()
    {
        return $"{NomeItem} - {ValorItem.ToString("C2")} - {DataCadastroItem.ToShortDateString()}";
    }
}
