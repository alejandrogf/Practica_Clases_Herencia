using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clases_Herencia.clases
{
    public class Rectangulo:Figuras, ICalculosGeometricos, IComparable, IComparer

    {

        public double Ancho { get; set; }
        public double Alto { get; set; }


        public override string FuncionArea()
        {
            var area = Alto*Ancho;
            return "\n\nLa fórmula del área es: Alto X Ancho.\n" +
                   "Tu resultado es:"+ Alto + " * " + Ancho + " = " + area;
        }

        public override string FuncionPerimetro()
        {
            var perimetro = ((Alto*2) + (Ancho*2));
            return "\n\nLa fórmula del perímetro es: (Alto X 2) + (Ancho X 2).\n" +
            "Tu resultado es: (" + Alto + "X 2 ) + (" + Ancho + "X 2) = " + perimetro;

        }

        public double CalcularMetros()
        {
            throw new NotImplementedException();
        }

        public double CalcularPrecioTotal(double precioMetro)
        {
            throw new NotImplementedException();
        }

        public void Representar()
        {
            throw new NotImplementedException();
        }

        public void Colorear(string color)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}
