﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clases_Herencia.clases
{
    public class Circulo:Figuras
    {
        public int Radio { get; set; }

        public override string FuncionArea()
        {
            var area = Math.PI * Radio * Radio;
            return "\n\nLa fórmula del área es: Pi X Radio^2.\n" +
                   "Tu resultado es:" + Math.PI + "X" + Radio + "^2 =" + area;
        }

        public override string FuncionPerimetro()
        {
            var perimetro = Math.PI * Radio * Radio;
            return "\n\nLa fórmula del perímetro es: 2 X Pi X Radio.\n" +
                   "Tu resultado es: 2X" + Math.PI + "X" + Radio + "=" + perimetro;

        }
    }
}
