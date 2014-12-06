
using System.Collections.Generic;

namespace CondominioFacilDDD.Domain.Entities
{
    public class Rua
    {
        public int RuaId { get; set; } // PK -> Primary Key 
        public string Nome { get; set; }

        public virtual IEnumerable<Residencia> Residencias { get; set; }
        //Relação 1 .. N --  Uma Rua tem varias Residencias -- Rua 1 - Residencia N 
    }
}
