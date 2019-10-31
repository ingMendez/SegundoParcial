using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransaccionBLL
    {
        public static bool Guardar(Transacciones transaccion)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (contexto.transaciones.Add(transaccion) != null)
                {
                    contexto.SaveChanges(); //Guardar los cambios
                    paso = true;
                }
                contexto.clietnes.Find(transaccion.ClienteId).Balance += transaccion.Monto;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
    }
}
