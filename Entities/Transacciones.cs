using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Transacciones
    {
        [Key]
        public int TransacionId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public  Transacciones()
        {
            TransacionId = 0;
            ClienteId = 0;
            Fecha = DateTime.Now;
            Tipo = string.Empty;
            Monto = 00;
        }
    }
}
