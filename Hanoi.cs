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
        public void mover_disco(Pila a, Pila b)
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
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int cont = 0; // Contador de movimientos
            Console.WriteLine("Situación inicial");
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
            // Algoritmo iterativo
            // Para números pares
            if (n % 2 != 0)
            {
                while (fin.Size != n)
                {
                    // Movimiento de 'ini' a 'fin'
                    mover_disco(ini, fin);
                    cont++;
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
                    mover_disco(ini, aux);
                    cont++;
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
                    mover_disco(aux, fin);
                    cont++;
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
            // Para números impares
            else if (n % 2 == 0)
            {
                // Algoritmo para el caso cuando 'n' es par
                while (fin.Size != n)
                {
                    // Mover disco de 'ini' a 'aux'
                    mover_disco(ini, aux);
                    cont++; // Incrementar contador de movimientos
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
                    // Verificar si se alcanzó la situación final
                    if (fin.Size == n)
                    {
                        return cont; // Devolver el número de movimientos realizados
                    }

                    // Mover disco de 'ini' a 'fin'
                    mover_disco(ini, fin);
                    cont++; // Incrementar contador de movimientos
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
                    // Verificar si se alcanzó la situación final
                    if (fin.Size == n)
                    {
                        return cont;
                    }

                    // Mover disco de 'aux' a 'fin'
                    mover_disco(aux, fin);
                    cont++; // Incrementar contador de movimientos
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
                    // Verificar si se alcanzó la situación final
                    if (fin.Size == n)
                    {
                        return cont;
                    }
                }
            }

            return cont;

        }

    }
}
