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
    
    [Column("parcela_divida")]
    public int ParcelaDivida { get; set; }     
    
    [Column("parcela_divida_paga")]
    public int ParcelaDividaPaga { get; set; }
    
    [Column("parcela_divida_valor_liquido")]
    public decimal ParcelaDividaValorLiquido { get; set; }       

    [Column("divida_ativa")]
    public bool DividaAtiva { get; set; }                           
}
