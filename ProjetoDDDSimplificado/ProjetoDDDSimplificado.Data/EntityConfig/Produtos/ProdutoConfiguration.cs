using System;
using ProjetoDDDSimplificado.Domain.Entidades.Produtos;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDDSimplificado.Data.EntityConfig.Produtos
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoID);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteID);

        }
    }
}
