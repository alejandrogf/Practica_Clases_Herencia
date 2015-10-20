using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clases_Herencia.clases
{
    public class Circulo:Figuras
    {
        private float _pi;
        public float Pi
        {
            set
            { _pi = (float) 3.1416; }
            get
            { return _pi; }
        }
        public int Radio { get; set; }

        public override float FuncionArea()
        {
            return (float) (Pi*Radio*Radio);
        }

        public override float FuncionPerimetro()
        {
            return (float) (2*Pi*Radio);
        }
    }
}
