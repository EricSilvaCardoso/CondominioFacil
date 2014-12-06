namespace CondominioFacilDDD.Domain.Entities
{
    public class Residencia
    {
        public int ResidenciaId { get; set; } // PK -> Primary Key 
        public string NResidencia { get; set; }
        
        public int RuaId { get; set; } //FK Foreign Key
        public virtual Rua Rua { get; set; }
        //Relação 1 .. 1 --  Uma Residencia tem uma Rua  -- Residencia 1 - 1 Rua 
    }
}
