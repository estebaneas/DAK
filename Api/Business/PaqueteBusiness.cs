using CommonSolution;
using CommonSolution.Dtos;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PaqueteBusiness
    {
        private PaqueteRepository PaqueteRep;
        public PaqueteBusiness ()
        {
            this.PaqueteRep = new PaqueteRepository();
        }
        public Mensaje registrarPaquete(PaqueteDto paquete,int numFactura)
        {
            Mensaje mensaje = new Mensaje();
            mensaje.descripcion = "numero = numero de paquete";
            paquete.FechaRecivido = DateTime.Now;
            paquete.Estado = (int)ESTADO.RECIBIDO;
            paquete.Numero_Factura = numFactura;
            int? numeroPaquete = this.PaqueteRep.registrarPaquete(paquete);
            if (numeroPaquete!=null)
            {
                mensaje.numero = numeroPaquete;
            }
            else
            {
                mensaje.colErrores.Add("Hubo un error con la base de datos al registrar paquete");
            }
            return mensaje;
        }

    }
}
