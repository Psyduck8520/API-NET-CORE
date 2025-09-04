using ApiPeliculas.Modelos;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace ApiPeliculas.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio  
    {

        //Aqui en la intefaz  solo definimos los metodos  que vamos a utilizar en el repositorio

        //primero es un metodo ICOLECION PARA TRAER LOS DATOS 

        ICollection<ICategoriaRepositorio> GetCategorias(); // Tramos la informacion para todas la categoria
        
        Categoria GetCategoria(int categoriaId); // este  es solo para los edividuales 
       
        bool ExisteCategoria(int categoriaId); // para validar  si existe el id  de la categoria 

        bool ExisteCategoria(string nombre); // existe categoria por el nombre, aveces tenemos que validar los nombres de la categoria
        
        bool CrearCategoria(Categoria categoria); // crear categoria por eso le pasamos  el tipo de dato de categoria
        
        bool ActualizarCategoria(Categoria categoria); // actualizar categoria por eso le pasamos  el tipo de dato de categoria
        bool BorrarCategoria(Categoria categoria); // borrar categoria por eso le pasamos  el tipo de dato de categoria
        
        bool Guardar(); // guardar los cambios
    }
}
