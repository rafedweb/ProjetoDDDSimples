using System;
using ProjetoDDDSimplificado.Domain.Entidades.Clientes;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDDSimplificado.Data.EntityConfig.Clientes
{
    class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
