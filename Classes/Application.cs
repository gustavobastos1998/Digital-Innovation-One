using System;

using Classes.Herança;
using Classes.Metodos;

namespace Classes
{
    class Application
    {
        static void Main(string[] args)
        {
            Ponto ponto1 = new Ponto(10, 20);
            Ponto ponto2 = new Ponto3D(10, 20, 30);
            Ponto3D.Calcular();

            int input1 = 10, input2 = 20;
            Ref.Inverter(input1, input2);
            Console.WriteLine("primeiro input = " + input1 + " segundo input = " + input2);
            int numerador = 123, denominador = 2;
            Out.Dividir(numerador, denominador);
        }
    }
}
