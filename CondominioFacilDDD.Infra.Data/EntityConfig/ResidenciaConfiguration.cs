using System.Data.Entity.ModelConfiguration;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Infra.Data.EntityConfig
{
    public class ResidenciaConfiguration : EntityTypeConfiguration<Residencia>
    {
        public ResidenciaConfiguration()
        {
            HasKey(p => p.ResidenciaId);

            HasRequired(p => p.Rua)
                .WithMany()
                .HasForeignKey(p => p.RuaId);

            Property(p => p.NResidencia)
                .IsRequired();

        }
    }
}
