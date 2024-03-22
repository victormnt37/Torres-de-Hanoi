
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
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; } = new List<Disco>();

        // Constructor de la pila que inicializa la pila con 'n' discos
        public Pila(int n)
        {
            this.Size = n;  // Establecer el tamaño de la pila
            // Agregar discos a la pila, con valores decrecientes desde 'n' hasta 1
            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                this.Elementos.Add(disco);
            }
            this.Top = this.Elementos[this.Size - 1].Valor;  // Establecer el valor en la parte superior de la pila
        }

        // Constructor de la pila sin parámetros, inicializa una pila vacía
        public Pila()
        
            this.Size = 0;
            this.Top = 0;
        }

        // Método para insertar un disco en la parte superior de la pila
        public void push(Disco d)
        {
            this.Size++;            
            this.Top = d.Valor;     
            this.Elementos.Add(d);
        }

        // Método para eliminar y devolver el disco en la parte superior de la pila
        public Disco pop()
        {
            Disco disco = new Disco();
            disco = this.Elementos[this.Size - 1];  // Obtener el disco en la parte superior de la pila
            this.Elementos.Remove(disco);   // Eliminar el disco de la lista de elementos de la pila
            this.Size--;
            // Actualizar el valor en la parte superior de la pila, si la pila no está vacía
            if (this.Size > 0)
                this.Top = this.Elementos[this.Size - 1].Valor;
            return disco;
        }

        // Método para verificar si la pila está vacía
        public bool isEmpty()
        {
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
