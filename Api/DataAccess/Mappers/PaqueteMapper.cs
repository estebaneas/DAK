using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSolution.Dtos;
using DataAccess.Model;
namespace DataAccess.Mappers
{
    class PaqueteMapper
    {
        public Paquete toEntity(PaqueteDto entrada)
        {
            Paquete salida = new Paquete();
            salida.Calle = entrada.Calle;
            salida.DocumentoDestinatario = entrada.DocumentoDestinatario;
            salida.DocumentoRemitente = entrada.DocumentoRemitente;
            salida.Distancia = entrada.Distancia;
            salida.DetalleDireccion = entrada.DetalleDireccion;
            salida.ID_Condado = entrada.ID_Condado;
            salida.ID_Zona = entrada.ID_Zona;
            salida.ID = entrada.ID;
            salida.FechaCambioEstado = entrada.FechaCambioEstado;
            salida.FechaEnviado = entrada.FechaEnviado;
            salida.FechaRecivido = entrada.FechaRecibido;
            salida.Estado = entrada.Estado;
            salida.Tamano = entrada.Tamano;
            salida.Numero_Factura = entrada.Numero_Factura;
            salida.Localidad = entrada.Localidad;
            salida.Peso = entrada.Peso;
            salida.TrackingNumero = entrada.TrackingNumero;
            return salida;
        }

        public List<Paquete> toEntity(List<PaqueteDto> entradas)
        {
            List<Paquete> salidas = new List<Paquete>();
            foreach (PaqueteDto item in entradas)
            {
                salidas.Add(this.toEntity(item));
            }
            return salidas;
        }


        public PaqueteDto toDto(Paquete entrada)
        {
            PaqueteDto salida = new PaqueteDto();
            salida.Calle = entrada.Calle;
            salida.DocumentoDestinatario = entrada.DocumentoDestinatario;
            salida.DocumentoRemitente = entrada.DocumentoRemitente;
            salida.Distancia = entrada.Distancia;
            salida.DetalleDireccion = entrada.DetalleDireccion;
            salida.ID_Condado = entrada.ID_Condado;
            salida.ID_Zona = entrada.ID_Zona;
            salida.ID = entrada.ID;
            salida.FechaCambioEstado = entrada.FechaCambioEstado;
            salida.FechaEnviado = entrada.FechaEnviado;
            salida.FechaRecibido = entrada.FechaRecivido;
            salida.Estado = entrada.Estado;
            salida.Tamano = entrada.Tamano;
            salida.Numero_Factura = entrada.Numero_Factura;
            salida.Localidad = entrada.Localidad;
            salida.Peso = entrada.Peso;
            salida.TrackingNumero = entrada.TrackingNumero;
            return salida;
        }

        public List<PaqueteDto> toDto(List<Paquete> entradas)
        {
            List<PaqueteDto> salidas = new List<PaqueteDto>();
            foreach (Paquete item in entradas)
            {
                salidas.Add(this.toDto(item));
            }
            return salidas;
        }
    }
}
