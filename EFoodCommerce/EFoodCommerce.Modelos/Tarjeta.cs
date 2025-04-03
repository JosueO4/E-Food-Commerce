using System.ComponentModel.DataAnnotations;

namespace EFoodCommerce.Modelos
{
    public class Tarjeta : IEntity
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(64)]
        public string Nombre { get; set; } = null!;

        [Required]
        public string Descripcion { get; set; } = null!;
    }
}
