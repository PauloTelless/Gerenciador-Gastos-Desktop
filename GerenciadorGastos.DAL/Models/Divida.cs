using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorGastos.DAL.Models;

public class Divida
{
    [Key]
    public int DividaId { get; set; }

    [Column("nome_divida")]
    public string NomeDivida { get; set; }

    [Column("data_cadastro_divida")]
    public DateTime DataCadastroDivida { get; set; }   
    
    [Column("valor_dividas")]
    public decimal ValorDivida { get; set; }                   
}
