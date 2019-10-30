using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{ [Serializable]
    public class Transacciones
    {
        [Key]
        public int TransacionId { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }

        Transacciones()
        {
            TransacionId = 0;
            Fecha = DateTime.Now;
            Tipo = string.Empty;
            Monto = 00;
        }
    }
}
