using System.ComponentModel.DataAnnotations;

namespace APIPelicula.Models.Dtos
{
    public class CategoriaDto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]

        public string? nombre { get; set; }

        public string? FechaCreacion { get; set; }
    }
}
