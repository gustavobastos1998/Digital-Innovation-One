using System;

namespace Revisão
{
    class Revisao
    {
        static void Main(string[] args)
        {
            char opcaoUsuario;
            do
            {
                menu();
                opcaoUsuario = Console.Read();
                if(opcaoUsuario == '1')
                {
                    //todo: adicionar alunos
                } 
                else if(opcaoUsuario == '2')
                {
                    //todo: listas todos os alunos
                } 
                else if (opcaoUsuario == '3')
                {
                    //todo: calcular édia geral
                } 
                else if(opcaoUsuario == '4')
                {
                    Console.WriteLine("Programa finalizado.");
                } 
                else 
                {
                    Console.WriteLine("Input inválido.");
                }
            } while(opcaoUsuario != '4');  
        }
        static void menu()
        {
            Console.WriteLine("Informe uma opção:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar todos os alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("4 - Finalizar programa")
        }
    }
}
