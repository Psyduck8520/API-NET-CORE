using ApiPeliculas.Data;
using ApiPeliculas.Modelos;
using ApiPeliculas.Repositorio.IRepositorio;

namespace ApiPeliculas.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio // tenemos que asegurarnos que esta clase  sea publica  , con alt enter  implementamos la interfaz
    {
        private readonly ApplicationDbContext _db; // creamos una variable  de tipo ApplicationDbContext  y la llamamos _db


        public CategoriaRepositorio(ApplicationDbContext  bd) // podemos poner  con ctor recibe como paramatro de tipo ApplicationDbContext
        {
            _db = bd; // inicializamos la variable _db con el parametro bd. con este podemos  acceder alas entidades que tenemos 
        }
    

        public bool ActualizarCategoria(Categoria categoria)
        {
            categoria.FechaCreacion = DateTime.Now; // tomamos  la fecha  actual 
            _db.Categoria.Update(categoria);
            return Guardar();
        }

        public bool BorrarCategoria(Categoria categoria)
        {
            _db.Categoria.Remove(categoria);  
            return Guardar()  ;
        }

        public bool CrearCategoria(Categoria categoria)
        {
            categoria.FechaCreacion = DateTime.Now; // tomamos  la fecha  actual 
            _db.Categoria.Add(categoria);
            return Guardar();
        }

        public bool ExisteCategoria(int categoriaId)
        {
            return _db.Categoria.Any(c => c.Id == categoriaId); // verificamos si existe  alguna categoria con el id que estamos pasando 
        }

        public bool ExisteCategoria(string nombre)
        {
            bool valor = _db.Categoria.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim()); // verificamos si existe  alguna categoria con el nombre que estamos pasando, comoararlo con la base de datos
            return Guardar();
            
        }
        public Categoria GetCategoria(int categoriaId)
        {
            return _db.Categoria.FirstOrDefault(c => c.Id == categoriaId); // traemos la primera categoria que coincida con el id que estamos pasando
        }

        public ICollection<Categoria> GetCategorias()
        {

            return _db.Categoria.OrderBy(c => c.Nombre).ToList(); // traemos todas las categorias y las ordenamos por nombre
        }
        public bool Guardar()
        {
            return _db.SaveChanges() >= 0 ? true : false; // si se guardo  los cambios  devolvemos true  si no false, si uno  de los registros  es mayor a cero 
            //va guardar los cambios se crea un registro .se pudo  guardar  se puedo actualizar.
        }

    }
}
