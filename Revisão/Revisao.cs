using System;

namespace Revisão
{
    class Revisao
    {
        static void Main(string[] args)
        {
            string opcaoUsuario;
            Aluno[] alunos = new Aluno[5]; //cinco alunos no array
            var indexStudent = 0;
            do
            {
                menu();
                opcaoUsuario = Console.ReadLine();
                if(opcaoUsuario == "1")
                {
                    Console.WriteLine("Informe o nome do aluno:");
                    Aluno newAluno = new Aluno();
                    var nameNewStudent = Console.ReadLine();
                    newAluno.Name = nameNewStudent;
                    Console.WriteLine("Informe a nota desse aluno:");
                    if(decimal.TryParse(Console.ReadLine(), out decimal nota)) // TryParse pergunta se pode fazer o parse do string para decimal, se puder, retorna true e o out decimal nota terá seu valor
                    {
                        newAluno.Nota = nota;
                    }
                    else // caso não de para fazer o parser, o usuário informou um valor que não é decimal
                    {
                        throw new ArgumentException("Valor da nota deve ser um decimal");
                    }
                    alunos[indexStudent] = newAluno;
                    indexStudent = indexStudent + 1;
                } 
                else if(opcaoUsuario == "2")
                {
                    foreach (var student in alunos)
                    {
                        if (string.IsNullOrEmpty(student.Name) == false)
                        {
                            Console.WriteLine("Nome do aluno: "+student.Name
                            + "\nNota do aluno: "+student.Nota);
                        }
                    }
                } 
                else if (opcaoUsuario == "3")
                {
                    //todo: calcular édia geral
                } 
                else if(opcaoUsuario == "4")
                {
                    Console.WriteLine("Programa finalizado.");
                } 
                else 
                {
                    Console.WriteLine("Input inválido.");
                }
            } while(opcaoUsuario != "4");  
        }
        private static void menu()
        {
            Console.WriteLine("\nInforme uma opção:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar todos os alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("4 - Finalizar programa\n");
        }
    }
}
