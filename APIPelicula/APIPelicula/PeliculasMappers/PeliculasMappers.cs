using APIPelicula.Models.Dtos;
using APIPelicula.Models;
using AutoMapper;

namespace APIPelicula.PeliculasMappers
{
    public class PeliculasMappers : Profile
    {
        public PeliculasMappers()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
        }
    }
}
