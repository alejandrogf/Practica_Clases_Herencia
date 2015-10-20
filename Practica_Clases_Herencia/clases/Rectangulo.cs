using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clases_Herencia.clases
{
    public class Rectangulo:Figuras
    {

        public int Ancho { get; set; }
        public int Alto { get; set; }


        public override string FuncionArea()
        {
            var area = Alto*Ancho;
            return "La fórmula del área es: Alto X Ancho.\n" +
                   "Tu resultado es:"+ Alto + "+" + Ancho + "=" + area;
        }

        public override string FuncionPerimetro()
        {
            var perimetro = ((Alto*2) + (Ancho*2));
            return "La fórmula del perímetro es: (Alto X 2) + (Ancho X 2).\n" +
            "Tu resultado es: (" + Alto + "X 2 ) + (" + Ancho + "X 2) = " + perimetro;

        }
    }
}
