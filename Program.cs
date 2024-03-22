using System;
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
            // Se solicita al usuario el número de discos que desea usar
            Console.WriteLine("Dime el número de discos: ");
            int n = Int32.Parse(Console.ReadLine());
            while (n < 1)
            {
                // Comprobar que el numero de discos es válido
                Console.WriteLine("Has seleccionado " + n + " discos. Este valor no es válido, prueba con otro.");
                n = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Has seleccionado " + n + " discos");

            // Inicializamos tres pilas para las torres de Hanoi
            Pila ini = new Pila(n);
            Pila aux = new Pila();
            Pila fin = new Pila();

            // creamos una instancia de la clase Hanoi
            Hanoi hanoi = new Hanoi();

            // Se ejecuta el algoritmo de resolución de Hanoi y se obtiene el número de movimientos
            int movimiento = hanoi.iterativo(n, ini, aux, fin);
            Console.WriteLine("Lo has completado en " + movimiento + " movimientos");
            // Mantener abierta la ventana de la consola en modo de depuración
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
