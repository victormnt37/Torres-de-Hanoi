﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el número de discos: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Has seleccionado " + n + " discos");
            Pila ini = new Pila(n);
            Pila aux = new Pila();
            Pila fin = new Pila();
            Hanoi hanoi = new Hanoi();
            int movimiento = hanoi.iterativo(n, ini, aux, fin);
            Console.WriteLine("Lo has completado en " + movimiento + " movimientos");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}