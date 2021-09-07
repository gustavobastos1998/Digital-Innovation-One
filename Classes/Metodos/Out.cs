using System;

namespace Classes.Metodos
{
    class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir(int a, int b)
        {
            Dividir(a,b, out int resultado, out int resto);
            Console.WriteLine("resultado = " + resultado + "  resto = " + resto); 
        }
    }
}
