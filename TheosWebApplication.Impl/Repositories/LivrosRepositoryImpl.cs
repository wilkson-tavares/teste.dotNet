using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheosWebApplication.Domain.Entities;
using TheosWebApplication.Domain.Repositories;
using TheosWebApplication.Impl.Context;

namespace TheosWebApplication.Impl.Repositories
{
    public class LivrosRepositoryImpl : LivrosRepository
    {
        DBContextFactory dbContext;
        public LivrosRepositoryImpl(DBContextFactory context)
        {
            dbContext = context;
        }

        public IEnumerable<Livros> GetLivros()
        {
            return dbContext.Set<Livros>()
                    .Include(a => a.Autor)
                    .Include(g => g.Genero);
        }

        public Livros GetLivroById(int id)
        {
            return dbContext.Set<Livros>()
                    .Include(a => a.Autor)
                    .Include(g => g.Genero)
                    .FirstOrDefault(w => w.Id.Equals(id));
        }

        public void Save(Livros livro)
        {
            dbContext.Add(livro);
            dbContext.SaveChanges(true);
        }

        public void Update(Livros livro)
        {
            dbContext.Update(livro);
            dbContext.SaveChanges(true);
        }
    }
}
