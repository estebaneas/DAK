using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Strategies.GrupoConcreteStrategies
{
    public class Fijo : IGrupo
    {
        public double calcularPrecio(int distancia, double peso)
        {
            double precioFijo = 500;
            return precioFijo;
        }
    }
}
