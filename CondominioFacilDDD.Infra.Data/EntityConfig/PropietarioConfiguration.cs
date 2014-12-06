using System.Data.Entity.ModelConfiguration;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Infra.Data.EntityConfig
{
    public class PropietarioConfiguration : EntityTypeConfiguration<Propietario>
    {
        public PropietarioConfiguration()
        {
            HasKey(c => c.PropietarioId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.SobreNome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();

            Property(c => c.Telefone)
                .IsRequired();
        }
    }
}
