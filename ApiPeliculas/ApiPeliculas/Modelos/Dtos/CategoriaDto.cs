using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CategoriaDto // este es el que se va exponer , nos va servir para leer el
                              // registro individual y actualizar y no nos sirver para crear entonces necesito  otro DTO
    {
        //Aki vamos a poner todas las propiedades que queremos exponer, tambien podemos usar para listar  las catergorias que
        //que queremos listar
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")] // aki es necesario las validaciones
        [MaxLength(100, ErrorMessage = "El numero maximo de caracteres es de 100")]
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

}
