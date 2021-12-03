using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Strategies.GrupoConcreteStrategies
{
    public class DistanciaPeso : IGrupo
    {
        public double calcularPrecio(int distancia, double peso)
        {
            double precioKg = 50;
            double precioPorPeso = peso * precioKg;
            double precioTotal = (precioPorPeso * 0.25) * distancia;

            return precioTotal;
        }
    }
}
