
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
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; } = new List<Disco>();


        public Pila(int n)
        {
            this.Size = n;
            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                this.Elementos.Add(disco);
            }
            this.Top = this.Elementos[this.Size - 1].Valor;
        }

        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
        }

        public void push(Disco d)
        {
            this.Size++;
            this.Top = d.Valor;
            this.Elementos.Add(d);
        }
        public Disco pop()
        {
            Disco disco = new Disco();
            disco = this.Elementos[this.Size - 1];
            this.Elementos.Remove(disco);
            this.Size--;
            if (this.Size > 0)
                this.Top = this.Elementos[this.Size - 1].Valor;
            return disco;
        }
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