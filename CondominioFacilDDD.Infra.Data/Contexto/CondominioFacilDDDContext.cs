using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Infra.Data.EntityConfig;

namespace CondominioFacilDDD.Infra.Data.Contexto
{
    public class CondominioFacilDDDContext : DbContext
    {
        public CondominioFacilDDDContext()
            : base("CondominioFacilDDD")
        {

        }

        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Rua> Ruas{ get; set; }
        public DbSet<Residencia> Residencias { get; set; }
        public DbSet<Condominio> Condominios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)        //Desabilita convenções
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();      //Romove pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();    // Remove o delete em cascata com relação 1 .. N 
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();   // Remove o delete em cascata com relação N .. N

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")                  //Configura o contexto que qdo houver uma propiedade
                .Configure((p => p.IsKey()));                                       // que o nome +Id ele sera chave primaria

            modelBuilder.Properties<string>()                                       //Configura o contexto que qdo houver uma string
                .Configure(p => p.HasColumnType("varchar"));                        //sera varchar

            modelBuilder.Properties<string>()                                       //Configura o contexto que qdo houver uma string
                .Configure(p => p.HasMaxLength(100));                               //e nao for informado tamanho sera 100
        
            modelBuilder.Configurations.Add(new PropietarioConfiguration());
            modelBuilder.Configurations.Add(new RuaConfiguration());
            modelBuilder.Configurations.Add(new ResidenciaConfiguration());
            modelBuilder.Configurations.Add(new CondominioConfiguration());
        }

        public override int SaveChanges()                                           // sobrescreve o metedo savechanges
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
            return base.SaveChanges();                                              //Configura o changeTracker qdo a entidade tiver DataCadastro
        }                                                                           //acha a propiedade e qdo estiver add ele coloca a data atual
                                                                                    // e quando estiver modificando nada a fazer
    }
}
