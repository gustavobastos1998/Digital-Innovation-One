using System;

namespace Classes.Metodos
{
    class Ref
    {
        static void Inverter(ref int x, ref int y) // precisa do ref aqui tbm
        {
            int temp = x;
            x = y;
            y = temp; 
        }

        public static void Inverter(int a, int b)
        {
            int i = a, j = b;
            Inverter(ref i, ref j); // por conter o 'ref' altera o valor das variáveis locais
            Console.WriteLine($"{i} {j}"); 
        } 
    }
}
