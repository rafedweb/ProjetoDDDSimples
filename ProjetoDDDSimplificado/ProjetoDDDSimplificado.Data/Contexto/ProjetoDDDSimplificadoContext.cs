using System;
using ProjetoDDDSimplificado.Data.EntityConfig.Clientes;
using ProjetoDDDSimplificado.Data.EntityConfig.Produtos;
using ProjetoDDDSimplificado.Domain.Entidades.Clientes;
using ProjetoDDDSimplificado.Domain.Entidades.Produtos;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;


namespace ProjetoDDDSimplificado.Data.Contexto
{
    class ProjetoDDDSimplificadoContext : DbContext
    {
        public ProjetoDDDSimplificadoContext()
            : base("ProjetoDDDSimplificado")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
