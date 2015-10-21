using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clases_Herencia.clases
{
    public class Circulo:Figuras
    {
        public double Radio { get; set; }

        public override string FuncionArea()
        {
            double area = Math.PI * Math.Pow(Radio,2);
            return "\n\nLa fórmula del área es: Pi X Radio^2.\n" +
                   "Tu resultado es:" + Math.PI + " X " + Radio + "^2 = " + area;
        }

        public override string FuncionPerimetro()
        {
            double perimetro = 2*Math.PI * Radio;
            return "\n\nLa fórmula del perímetro es: 2 X Pi X Radio.\n" +
                   "Tu resultado es: 2 X " + Math.PI + " X " + Radio + " = " + perimetro;

        }
    }
}
