using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheosWebApplication.Domain.Entities;

namespace TheosWebApplication.Impl.Configuration
{
    public class LivrosConfig
    {
        public LivrosConfig(ModelBuilder builder)
        {
            builder.Entity<Livros>(etd =>
            {
                etd.ToTable("TB_LIVROS");
                etd.HasKey(c => c.Id).HasName("ID");
                etd.Property(c => c.Id).HasColumnName("ID").UseSqlServerIdentityColumn().IsRequired();
                etd.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
                etd.Property(c => c.AutorId).HasColumnName("AUTOR_ID").IsRequired();
                etd.Property(c => c.GeneroId).HasColumnName("GENERO_ID").IsRequired();
            });
        }
    }
}
