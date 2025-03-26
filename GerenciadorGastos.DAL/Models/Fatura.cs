using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorGastos.DAL.Models;

public class Fatura
{
    [Key]
    public int FaturaId { get; set; }

    [Column("fatura_valor")]
    public decimal ValorFatura { get; set; }
}
