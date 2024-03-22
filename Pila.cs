
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        // Propiedades de la pila
        public int Size { get; set; }              // Tamaño
        public int Top { get; set; }               // Valor en la parte superior
        public List<Disco> Elementos { get; set; } // Elementos

        // Constructor de la pila que inicializa la pila con 'n' discos
        public Pila(int n)
        {
            this.Size = n;  // Establecer el tamaño de la pila
            // Agregar discos a la pila, con valores decrecientes desde 'n' hasta 1
            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco();  // Crear un nuevo disco
                disco.Valor = i;            // Establecer el valor del disco
                this.Elementos.Add(disco);  // Agregar el disco a la lista de elementos de la pila
            }
            this.Top = this.Elementos[this.Size - 1].Valor;  // Establecer el valor en la parte superior de la pila
        }

        // Constructor de la pila sin parámetros, inicializa una pila vacía
        public Pila()
        {
            this.Size = 0;   // Tamaño de la pila igual a cero
            this.Top = 0;    // Valor en la parte superior de la pila igual a cero
        }

        // Método para insertar un disco en la parte superior de la pila
        public void push(Disco d)
        {
            this.Size++;            // Incrementar el tamaño de la pila
            this.Top = d.Valor;     // Actualizar el valor en la parte superior de la pila con el valor del nuevo disco
            this.Elementos.Add(d); // Agregar el nuevo disco a la lista de elementos de la pila
        }

        // Método para eliminar y devolver el disco en la parte superior de la pila
        public Disco pop()
        {
            Disco disco = new Disco();  // Crear un nuevo objeto de tipo Disco
            disco = this.Elementos[this.Size - 1];  // Obtener el disco en la parte superior de la pila
            this.Elementos.Remove(disco);   // Eliminar el disco de la lista de elementos de la pila
            this.Size--;    // Decrementar el tamaño de la pila
            // Actualizar el valor en la parte superior de la pila, si la pila no está vacía
            if (this.Size > 0)
                this.Top = this.Elementos[this.Size - 1].Valor;
            return disco;   
        }

        // Método para verificar si la pila está vacía
        public bool isEmpty()
        {
            // Devolver verdadero si el tamaño de la pila es cero, de lo contrario, devolver falso
            if (this.Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
