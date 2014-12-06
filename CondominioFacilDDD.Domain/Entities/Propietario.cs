using System;
using System.Collections.Generic;

namespace CondominioFacilDDD.Domain.Entities
{
    public class Propietario
    {
        public int PropietarioId { get; set; } // PK -> Primary Key 
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Condominio> Condominios { get; set; }
        //Relação 1 .. N --  Um Propietario pode ter varios Condominios --  Propietario 1 - Condominios N 
        
        public bool PropietarioEspecial(Propietario propietario)
        {
            return propietario.Ativo && DateTime.Now.Year - propietario.DataCadastro.Year >= 5;
        }
    }
}
