﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Clases_Herencia.clases;

namespace Practica_Clases_Herencia
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué figura deseas calcular?");
            Console.WriteLine("1.- Rectángulo.{0}2.- Circulo {0}", Environment.NewLine);
            var seleccion = Console.ReadLine();
            if (seleccion == "1")
            {
                Console.WriteLine("{0}{0}Has elegido el rectángulo." +
                                  "{0}{0}Indica su ancho:", Environment.NewLine);
                var ancho = double.Parse(Console.ReadLine());

                Console.WriteLine("{0}Indica su alto:", Environment.NewLine);

                var alto = double.Parse(Console.ReadLine());

                var rect = new Rectangulo()
                {
                    Ancho = ancho,
                    Alto = alto
                };

                Console.WriteLine(rect.FuncionArea());
                Console.WriteLine(rect.FuncionPerimetro());

            } else if (seleccion == "2")
            {

                Console.WriteLine("{0}{0}Has elegido el círculo." +
                                  "{0}{0}Indica su radio:", Environment.NewLine);
                var radio = double.Parse(Console.ReadLine());

                var circ = new Circulo()
                {
                    Radio = radio
                };

                Console.WriteLine(circ.FuncionArea());
                Console.WriteLine(circ.FuncionPerimetro());
            }

                Console.WriteLine("{0}{0}¡Hasta pronto! " +
                                  "{0}(Pulsa cualquier tecla para salir)",
                                  Environment.NewLine);
                Console.ReadLine();

            

        }
    }
}
