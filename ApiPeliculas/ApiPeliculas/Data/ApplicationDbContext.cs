using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data //necesitamos crear una carpeta Data y dentro de ella crear una clase llamada ApplicationDbContext que herede de DbContext
{
    public class ApplicationDbContext : DbContext //aki realizacion la importancion de Ent
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // esto es un constructor que recibe las opciones de configuracion de la base de datos
        {

            
        }
        //Aki tenemos que pasar todos los modelos  o entidades que vamos a utilizar en la base de datos
        public DbSet<Modelos.Categoria> Categoria { get; set; } //esto es una propiedad que representa una tabla en la base de datos


    }
}
