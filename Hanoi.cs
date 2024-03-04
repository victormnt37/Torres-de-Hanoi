using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{

    public class Hanoi
    {
        // Método para mover un disco entre dos pilas
        public static void MoverDisco(Pila a, Pila b)
        {
            if (a.EstaVacia() && b.EstaVacia())
            {
                Console.WriteLine("No hay discos para mover.");
                return;
            }

            Disco discoA = a.VerTope();
            Disco discoB = b.VerTope();

            if (a.EstaVacia() || (discoB != null && discoA.Tamaño > discoB.Tamaño))
            {
                // Mover disco de b a a
                Disco discoMovido = b.ExtraerDisco();
                a.AgregarDisco(discoMovido);
                Console.WriteLine($"Mover disco de tamaño {discoMovido.Tamaño} de {b.Nombre} a {a.Nombre}");
            }
            else
            {
                // Mover disco de a a b
                Disco discoMovido = a.ExtraerDisco();
                b.AgregarDisco(discoMovido);
                Console.WriteLine($"Mover disco de tamaño {discoMovido.Tamaño} de {a.Nombre} a {b.Nombre}");
            }
        }

        // Método para resolver las Torres de Hanoi
        public static int ResolverHanoi(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;

            if (n % 2 == 1)
            {
                // Número impar de discos
                while (fin.ContarDiscos() != n)
                {
                    MoverDisco(ini, aux);
                    movimientos++;

                    if (fin.ContarDiscos() == n)
                        break;

                    MoverDisco(ini, fin);
                    movimientos++;

                    if (fin.ContarDiscos() == n)
                        break;

                    MoverDisco(aux, fin);
                    movimientos++;
                }
            }
            else
            {
                // Número par de discos
                while (fin.ContarDiscos() != n)
                {
                    MoverDisco(ini, fin);
                    movimientos++;

                    if (fin.ContarDiscos() == n)
                        break;

                    MoverDisco(ini, aux);
                    movimientos++;

                    if (fin.ContarDiscos() == n)
                        break;

                    MoverDisco(aux, fin);
                    movimientos++;
                }
            }

            return movimientos;
        }
    }
}
