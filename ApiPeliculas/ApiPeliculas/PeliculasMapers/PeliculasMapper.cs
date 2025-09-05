using ApiPeliculas.Modelos;
using ApiPeliculas.Modelos.Dtos;
using AutoMapper;

namespace ApiPeliculas.PeliculasMaper
{

    public class PeliculasMapper: Profile

    {
        public PeliculasMapper() //1.  creamos el constructor
        {
             CreateMap<Categoria, CategoriaDto>().ReverseMap(); //2.  creamos el mapeo entre las dos clases, el reverse es para que exista comunicacion en ambos sentidos
            CreateMap<Categoria, CrearCatergoriaDto>().ReverseMap(); //2.  creamos el mapeo entre las dos clases

        }


    }
}
