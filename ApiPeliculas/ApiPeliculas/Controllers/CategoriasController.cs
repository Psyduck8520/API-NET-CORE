using ApiPeliculas.Modelos.Dtos;
using ApiPeliculas.Repositorio.IRepositorio;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPeliculas.Controllers
{
    [Route("api/categorias")]
    [ApiController]
    public class CategoriasController : ControllerBase //heredamos de ControllerBase porque no necesitamos las vistas
    {
        private readonly ICategoriaRepositorio _ctRepo; //inyectamos el repositorio
        private readonly  IMapper _mapper; //inyectamos el mapper  para pode acceder a los metodos de mapeo
        public CategoriasController(ICategoriaRepositorio ctRepo, IMapper mapper) //inyectamos el repositorio y el mapper en el constructor
        {
            _ctRepo = ctRepo;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetCategorias() //metodo para traer todas las categorias
        {
            var listaCategorias = _ctRepo.GetCategorias(); //traemos todas las categorias del repositorios 
            //para no exponer el modelo  Categoria  vamos a utilizar el mapper para mapear  la lista de categorias a una lista de CategoriaDto
            var listaCategoriasDto = new List<CategoriaDto>(); //creamos una lista vacia de CategoriaDto

            foreach (var lista in listaCategorias) //recorremos la lista de categorias
            {
                listaCategoriasDto.Add(_mapper.Map<CategoriaDto>(lista)); //mapeamos cada categoria a CategoriaDto y la agregamos a la lista
            }
            return Ok(listaCategoriasDto); //devolvemos la lista de CategoriaDto

        }

    }
}
