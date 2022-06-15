using System.ComponentModel.DataAnnotations;

namespace APIPelicula.Models.Dtos
{
    public class CategoriaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]

        public string? Nombre { get; set; }

        public string? FechaCreacion { get; set; }
    }
}
