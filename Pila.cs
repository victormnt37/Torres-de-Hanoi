using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; private set; }
        public Disco Top { get; private set; }
        public List<Disco> Elementos { get; private set; }

        public Pila()
        {
            Size = 0;
            Top = null;
            Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d;
            Size++;
        }

        public Disco pop()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("La pila está vacía");
            }

            Disco removed = Elementos[Size - 1];
            Elementos.RemoveAt(Size - 1);
            Size--;

            if (Size > 0)
            {
                Top = Elementos[Size - 1];
            }
            else
            {
                Top = null;
            }

            return removed;
        }

        public bool isEmpty()
        {
            return Size == 0;
        }
    }
}