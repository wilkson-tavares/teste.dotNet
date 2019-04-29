using System;
using System.Collections.Generic;
using System.Text;
using TheosWebApplication.Domain.Entities;

namespace TheosWebApplication.Domain.Repositories
{
    public interface LivrosRepository
    {
        IEnumerable<Livros> GetLivros();
        Livros GetLivroById(int id);
        void Save(Livros livro);
        void Update(Livros livro);
    }
}
