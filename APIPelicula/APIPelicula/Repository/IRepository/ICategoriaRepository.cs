using APIPelicula.Models;

namespace APIPelicula.Repository.IRepository
{
    public interface ICategoriaRepository
    {
        ICollection<Categoria> GetCategorias();

        Categoria GetCategory(int id);
        bool ExisteCategoria(string nombre);
        bool ExisteCategoria(int id);
        bool CrearCategoria(Categoria categoria);
        bool BorrarCategoria(Categoria categoria);
        bool Guardar();


    }
}
