using APIPelicula.Models;

namespace APIPelicula.Repository.IRepository
{
    public interface ICategoriaRepository
    {
        ICollection<Categoria> GetCategorias();

        Categoria GetCategoria(int id);
        bool ExisteCategoria(string nombre);
        bool ExisteCategoria(int id);
        bool CrearCategoria(Categoria categoria);
        bool BorrarCategoria(Categoria categoria);
        bool Guardar();
        bool ActualizarCategoria(Categoria categoria);
    }
}
