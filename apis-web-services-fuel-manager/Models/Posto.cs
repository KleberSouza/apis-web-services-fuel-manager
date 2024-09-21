using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apis_web_services_fuel_manager.Models
{
    [Table("Posto")]
    public class Posto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do posto é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O preço da gasolina é obrigatório.")]
        [Range(0.01, 100, ErrorMessage = "Preço inválido para a gasolina.")]
        public decimal PrecoGasolina { get; set; }

        [Required(ErrorMessage = "O preço do etanol é obrigatório.")]
        [Range(0.01, 100, ErrorMessage = "Preço inválido para o etanol.")]
        public decimal PrecoEtanol { get; set; }

        [Required(ErrorMessage = "O preço do diesel é obrigatório.")]
        [Range(0.01, 100, ErrorMessage = "Preço inválido para o diesel.")]
        public decimal PrecoDiesel { get; set; }

        public List<Consumo> Consumos { get; set; }
    }
}
