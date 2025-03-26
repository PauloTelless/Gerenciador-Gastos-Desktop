using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorGastos.DAL.Models;

public class GastoFixo
{
    [Key]
    public int GastoFixoId { get; set; }

    [Column("nome_gasto_fixo")]
    public string NomeGastoFixo { get; set; }

    [Column("data_cadastro_gasto_fixo")]
    public DateTime DataCadastroGastoFixo { get; set; }
    
    [Column("valor_gasto")]
    public decimal ValorGasto { get; set; }
}
