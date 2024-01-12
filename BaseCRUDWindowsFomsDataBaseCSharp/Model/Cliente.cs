using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseCRUDWindowsFomsDataBaseCSharp.model
{
        [Table("Clientes")]
        public class Cliente
    {
        private Cliente(int Id, string Name, string TpDocto, string Docto, string Telefone)
        {

        }
        public Cliente()
        {

        }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? TpDocto { get; set; }
        public string? Docto { get; set; }
        public string? Telefone { get; set; }
    }   
}
