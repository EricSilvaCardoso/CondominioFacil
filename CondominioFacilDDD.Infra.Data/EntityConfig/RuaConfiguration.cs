using System.Data.Entity.ModelConfiguration;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Infra.Data.EntityConfig
{
    public class RuaConfiguration : EntityTypeConfiguration<Rua>
    {
        public RuaConfiguration()
        {
            HasKey(p => p.RuaId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
