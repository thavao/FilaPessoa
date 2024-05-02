using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPessoa
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;
        int size;

        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return this.head == null && this.tail == null;
        }
        public void Push(Pessoa aux)
        {
            if (IsEmpty())
            {
                this.head = this.tail = aux;
                this.size++;

            }

            else
            {
                this.tail?.setNext(aux);
                this.tail = aux;
                this.size++;
            }

        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                if (tail == head)
                    tail = head = null;

                else
                {
                    head = head.getNext();
                    this.size--;
                }
            }
        }

        public void RunOver()
        {
            Pessoa aux = head;

            if (!IsEmpty())
            {
                do
                {
                    Console.WriteLine("Nome: " + aux.getNome());
                    aux = aux.getNext();
                } while (aux != null);
            }
            else
            {
                Console.WriteLine("Fila vazia...");
            }
        }

        public int getSize()
        {
            return this.size;
        }
    }
}