using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apis_web_services_fuel_manager.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o modelo!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a marca!")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa!")]
        [StringLength(7, ErrorMessage = "A placa deve ter no 7 caracteres.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano!")]
        [Range(1900,2100, ErrorMessage = "Ano inválido!")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "O usuário é obrigatório.")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public List<Consumo> Consumos { get; set; }
    }
}
