using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apis_web_services_fuel_manager.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A data do consumo é obrigatória.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O tipo de combustível é obrigatório.")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "O preco do combustível é obrigatório.")]
        [Range(0.01, 100, ErrorMessage = "O preco do combustível deve ser positivo.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O valor do consumo é obrigatório.")]
        [Range(0.01, 10000, ErrorMessage = "O valor do consumo deve ser positivo.")]
        public decimal Valor { get; set; }
        
        [Required(ErrorMessage = "O veículo é obrigatório.")]
        public int VeiculoId { get; set; }
        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

        [Required(ErrorMessage = "O posto é obrigatório.")]        
        public int PostoId { get; set; }
        [ForeignKey("PostoId")]
        public Posto Posto { get; set; }
    }

    public enum TipoCombustivel
    {
        Diesel,
        Etanol,
        Gasolina
    }
}
