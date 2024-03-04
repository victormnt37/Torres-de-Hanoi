using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    public class Disco
    {
        // Propiedad para almacenar el tamaño del disco
        public int Tamaño { get; private set; }

        // Constructor que acepta el tamaño del disco como parámetro
        public Disco(int tamaño)
        {
            Tamaño = tamaño;
        }

        // Método para imprimir información sobre el disco
        public void MostrarInformacion()
        {
            Console.WriteLine($"Disco de tamaño {Tamaño}");
        }
    }
}
