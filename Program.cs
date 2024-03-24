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
            int n;
            bool esNumero;

            do
            {
                // Se solicita al usuario el número de discos que desea usar
                Console.WriteLine("Indica el número de discos: ");

                string input = Console.ReadLine();

                esNumero = Int32.TryParse(input, out n); // Comprueba si el valor es un int

                // Comprobar que el numero de discos es válido
                if (!esNumero)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
                else if (n < 1)
                {
                    Console.WriteLine("El número debe ser mayor o igual a 1.");
                }
            } while (!esNumero || n < 1);

            Console.WriteLine("Has seleccionado " + n + " discos");

            // Inicializamos tres pilas para las torres de Hanoi
            Pila ini = new Pila(n);
            Pila aux = new Pila();
            Pila fin = new Pila();

            // creamos una instancia de la clase Hanoi
            Hanoi hanoi = new Hanoi();

            // Se ejecuta el algoritmo de resolución de Hanoi y se obtiene el número de movimientos
            int movimiento = hanoi.iterativo(n, ini, aux, fin);
            Console.WriteLine("Resuelto en " + movimiento + " movimientos");
            // Mantener abierta la ventana de la consola en modo de depuración
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
