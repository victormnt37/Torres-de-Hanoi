using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void MoverDisco(Pila a, Pila b)
        {

            if (b.isEmpty())
            {
                Disco disco = a.pop();
                b.push(disco);
            }
            else
            {
                if (b.Top > a.Top && !a.isEmpty())
                {
                    Disco disco = a.pop();
                    b.push(disco);
                }
                else
                {
                    Disco disco1 = b.pop();
                    a.push(disco1);
                }
            }
        }


        public int Iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int cont = 0;
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
            if (n % 2 != 0)
            {
                while (fin.Size != n)
                {
                    MoverDisco(ini, fin);
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
                    if (fin.Size == n)
                    {
                        return cont;
                    }

                    MoverDisco(ini, aux);
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
                    if (fin.Size == n)
                    {
                        return cont;
                    }

                    MoverDisco(aux, fin);
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
                    if (fin.Size == n)
                    {
                        return cont;
                    }
                }
            }
            if (n % 2 == 0)
            {
                while (fin.Size != n)
                {
                    MoverDisco(ini, aux);
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
                    if (fin.Size == n)
                    {
                        return cont;
                    }
                    MoverDisco(ini, fin);
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
                    if (fin.Size == n)
                    {
                        return cont;
                    }
                    MoverDisco(aux, fin);
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