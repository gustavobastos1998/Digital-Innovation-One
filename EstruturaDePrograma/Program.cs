using System;
using EstruturaDePrograma.EstruturaDeDados;

namespace EstruturaDePrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.push("abc");
            pilha.push(123);
            pilha.push(true);
            Console.WriteLine(pilha.pop());
            Console.WriteLine(pilha.pop());
            Console.WriteLine(pilha.pop());
            try{
                Console.WriteLine(pilha.pop());
            }catch(InvalidOperationException){
                Console.WriteLine("Não há como desempilhar, pilha está vazia");
            }
        }
    }
}
