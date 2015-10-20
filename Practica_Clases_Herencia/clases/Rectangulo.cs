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


        public override float FuncionArea()
        {
            return Ancho*Alto;
        }

        public override float FuncionPerimetro()
        {
            return (Ancho*2) + (Alto*2);
        }
    }
}
