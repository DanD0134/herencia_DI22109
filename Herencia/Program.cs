﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    /*programa de herencia es la caracteristica de pasar atributos y metodos a otros objetos o clases*/
    //clase Mamá
    class Operacion
    {
        //Guarda los espacios de memoria de 3 valores lolol
        // modificador tipo de dato nombre hola
        protected int valor1;
        protected int valor2;
        protected int resultado;
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
