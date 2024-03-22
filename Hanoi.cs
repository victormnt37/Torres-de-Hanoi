using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        // Método para mover un disco de una pila a otra
        public void MoverDisco(Pila a, Pila b)
        {
            // Verificar si la pila destino está vacía
            if (b.isEmpty())
            {
                // Si está vacía, mover el disco desde la pila 'a' a la pila 'b'
                Disco disco = a.pop();
                b.push(disco);
            }
            else
            {
                // Si la pila destino no está vacía, comparar los valores de los discos en la parte superior de ambas pilas
                if (b.Top > a.Top && !a.isEmpty())
                {
                    // Si el disco en la parte superior de la pila 'b' es mayor que el de la pila 'a', mover el disco desde 'a' a 'b'
                    Disco disco = a.pop();
                    b.push(disco);
                }
                else
                {
                    // Si el disco en la parte superior de la pila 'b' es menor o igual al de la pila 'a', mover el disco desde 'b' a 'a'
                    Disco disco1 = b.pop();
                    a.push(disco1);
                }
            }
        }

        // Método para resolver el problema de las Torres de Hanoi de forma iterativa
        public int Iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int cont = 0; // Contador de movimientos
            Console.WriteLine("Situación inicial");
            // Mostrar la situación inicial de las torres
            Console.Write("Torre INI: ");
            for (int i = 0; i < ini.Size; i++)
            {
                Console.Write(ini.Elementos[i].Valor);
            }
            Console.WriteLine();
            Console.Write("Torre AUX: ");
            for (int i = 0; i < aux.Size; i++)
            {
                Console.Write(aux.Elementos[i].Valor);
            }
            Console.WriteLine();
            Console.Write("Torre FIN: ");
            for (int i = 0; i < fin.Size; i++)
            {
                Console.Write(fin.Elementos[i].Valor);
            }
            Console.WriteLine();
            // Algoritmo iterativo para resolver el problema de las Torres de Hanoi
            if (n % 2 != 0)
            {
                while (fin.Size != n)
                {
                    // Movimiento de 'ini' a 'fin'
                    MoverDisco(ini, fin);
                    cont++;
                    // Mostrar la situación después del movimiento
                    Console.WriteLine("Situación tras movimiento " + cont);
                    Console.Write("Torre INI: ");
                    for (int i = 0; i < ini.Size; i++)
                    {
                        Console.Write(ini.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUX: ");
                    for (int i = 0; i < aux.Size; i++)
                    {
                        Console.Write(aux.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    Console.Write("Torre FIN: ");
                    for (int i = 0; i < fin.Size; i++)
                    {
                        Console.Write(fin.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    // Si se alcanza la situación final, devolver el número de movimientos
                    if (fin.Size == n)
                    {
                        return cont;
                    }

                    // Movimiento de 'ini' a 'aux'
                    MoverDisco(ini, aux);
                    cont++;
                    // Mostrar la situación después del movimiento
                    Console.WriteLine("Situación tras movimiento " + cont);
                    Console.Write("Torre INI: ");
                    for (int i = 0; i < ini.Size; i++)
                    {
                        Console.Write(ini.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUX: ");
                    for (int i = 0; i < aux.Size; i++)
                    {
                        Console.Write(aux.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    Console.Write("Torre FIN: ");
                    for (int i = 0; i < fin.Size; i++)
                    {
                        Console.Write(fin.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    // Si se alcanza la situación final, devolver el número de movimientos
                    if (fin.Size == n)
                    {
                        return cont;
                    }

                    // Movimiento de 'aux' a 'fin'
                    MoverDisco(aux, fin);
                    cont++;
                    // Mostrar la situación después del movimiento
                    Console.WriteLine("Situación tras movimiento " + cont);
                    Console.Write("Torre INI: ");
                    for (int i = 0; i < ini.Size; i++)
                    {
                        Console.Write(ini.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUX: ");
                    for (int i = 0; i < aux.Size; i++)
                    {
                        Console.Write(aux.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    Console.Write("Torre FIN: ");
                    for (int i = 0; i < fin.Size; i++)
                    {
                        Console.Write(fin.Elementos[i].Valor);
                    }
                    Console.WriteLine();
                    // Si se alcanza la situación final, devolver el número de movimientos
                    if (fin.Size == n)
                    {
                        return cont;
                    }
                }
            }
            if (n % 2 == 0)
            {
                // Algoritmo similar para cuando 'n' es par
            }

            return cont; // Devolver el número total de movimientos realizados
        }

    }
}
