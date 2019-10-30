using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public decimal Balance { get; set; }

        Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Balance = 00;

        }
       /* Clientes()
        {

        }*/
    }
}
