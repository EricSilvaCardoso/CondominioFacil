using System.Data.Entity.ModelConfiguration;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Infra.Data.EntityConfig
{
    public class CondominioConfiguration : EntityTypeConfiguration<Condominio>
    {
        public CondominioConfiguration()
        {
            HasKey(p => p.CondominioId);

            HasRequired(p => p.Residencia)
                .WithMany()
                .HasForeignKey(p => p.ResidenciaId);

            HasRequired(p => p.Propietario)
                .WithMany()
                .HasForeignKey(p => p.PropietarioId);
        }
    }
}
