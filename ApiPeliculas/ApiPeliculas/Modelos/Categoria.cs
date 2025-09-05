using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos
{
    public class Categoria
    {
        [Key] // este atributo indica que esta propiedad es la clave primaria de la entidad
        public int Id { get; set; }
        [Required] // este atributo indica que esta propiedad es obligatoria
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
