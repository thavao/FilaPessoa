using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPessoa
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string nome)
        {
            this.nome = nome;
            proximo = null;
        }
        public void setNext(Pessoa p)
        {
            this.proximo = p;
        }
        public Pessoa? getNext()
        {
            return this.proximo;
        }
        public string getNome()
        {
            return this.nome;
        }
    }
}
