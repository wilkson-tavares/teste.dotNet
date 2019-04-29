using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheosWebApplication.Domain.Entities;

namespace TheosWebApplication.Impl.Configuration
{
    public class GeneroConfig
    {
        public GeneroConfig(ModelBuilder builder)
        {
            builder.Entity<Genero>(etd =>
            {
                etd.ToTable("TB_GENERO");
                etd.HasKey(c => c.Id).HasName("ID");
                etd.Property(c => c.Id).HasColumnName("ID").UseSqlServerIdentityColumn().IsRequired();
                etd.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
            });
        }
    }
}
