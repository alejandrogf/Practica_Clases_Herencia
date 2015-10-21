using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clases_Herencia.clases
{
    public interface ICalculosGeometricos
    {
        double CalcularMetros();
        double CalcularPrecioTotal(double precioMetro);
        void Representar();
        void Colorear(string color);
    }
}
