using System.Runtime.CompilerServices;

namespace FilaPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPessoa filaPessoa = new FilaPessoa();

            Pessoa p1 = new("Zézinho");
            Pessoa p2 = new("Luizinho");
            Pessoa p3 = new("Pedrinho");
            filaPessoa.Push(p1);
            filaPessoa.Push(p2);
            filaPessoa.Push(p3);

            //filaPessoa.Push(p1);
            Console.WriteLine("Tamanho: " + filaPessoa.getSize());
            Console.WriteLine("Pessoas na fila:");
            filaPessoa.RunOver();
            filaPessoa.Pop();
            Console.WriteLine("------------\n\n\n");
            filaPessoa.RunOver();

        }
    }
}
