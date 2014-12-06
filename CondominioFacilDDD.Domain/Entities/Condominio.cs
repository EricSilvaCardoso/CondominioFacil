using System;

namespace CondominioFacilDDD.Domain.Entities
{
    public class Condominio
    {
        public int CondominioId { get; set; } // PK -> Primary Key 
        public int ResidenciaId { get; set; } //FK Foreign Key
        public int PropietatioId { get; set; } //FK Foreign Key
        public DateTime DataCadastro { get; set; }

        public virtual Residencia Residencia { get; set; }
        //Relação 1 .. 1 --  Uma Condominio tem uma Residencia  -- Condominio 1 - 1 Residencia
        public virtual Propietario Propietario { get; set; }
        //Relação 1 .. 1 --  Um Condominio tem um Propietario  -- Condominio 1 - 1 Propietario
    }
}
