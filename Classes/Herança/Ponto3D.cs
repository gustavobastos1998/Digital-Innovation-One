using System;

namespace Classes.Herança
{   
    class Ponto3D : Ponto // Herança 
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x,y)  
        { 
            this.z = z;
        }

        public int Distancia(Ponto a) 
        {
           return CalcularDistancia2d(a);  // há visualização por causa do protected
        }
        public override void CalcularDistancia()
        {
            // faz algo diferente da classe pai
        }

        public static void Calcular() // por ser static, eu preciso utilizar o nome da classe, e não a instancia da classe
        {
            // faz algo
        }
    }
}
