using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheosWebApplication.Domain.Entities;
using TheosWebApplication.Impl.Configuration;

namespace TheosWebApplication.Impl.Context
{
    public class DBContextFactory : DbContext
    {
        public DBContextFactory() { }

        public DBContextFactory(DbContextOptions<DBContextFactory> context) : base(context) { }

        DbSet<Livros> Livros { get; set; }
        DbSet<Autor> Autor { get; set; }
        DbSet<Genero> Genero { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=BD_LIVRARIA;Integrated Security=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.ForSqlServerUseIdentityColumns();
            construtorDeModelos.HasDefaultSchema("LIVRARIA");

            new LivrosConfig(construtorDeModelos);
        }
    }
}
