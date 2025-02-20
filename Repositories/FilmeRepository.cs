using api_filmes_senai.Domains;
using api_filmes_senai.interfaces;

namespace api_filmes_senai.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        public void Atualizar(Guid id, Filmes filme)
        {
            throw new NotImplementedException();
        }

        public Filmes BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Filmes novoFilme)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Filmes> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
