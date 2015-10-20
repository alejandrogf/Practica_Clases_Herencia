using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clases_Herencia.clases
{
    public abstract class Figuras
    {
        public string NombreFigura { get; set; }

        public abstract string FuncionArea();
        public abstract string FuncionPerimetro();
    }
}
