using APIPelicula.Data;
using APIPelicula.Models;
using APIPelicula.Repository.IRepository;

namespace APIPelicula.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _bd;

        public CategoriaRepository(ApplicationDbContext bd)
        {
            _bd = bd;
        }

        public bool BorrarCategoria(Categoria categoria)
        {
            _bd.Categoria.Remove(categoria);
            return Guardar();
        }

        public bool CrearCategoria(Categoria categoria)
        {
            _bd.Categoria.Add(categoria);
            return Guardar();
        }

        public bool ExisteCategoria(string nombre)
        {
            bool valor = _bd.Categoria.Any(c => c.Nombre.ToLower().Trim()== nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteCategoria(int id)
        {
            return _bd.Categoria.Any(c => c.Id == id);
        }

        public ICollection<Categoria> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public Categoria GetCategory(int id)
        {
            return _bd.Categoria.FirstOrDefault(c => c.Id == id);
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
