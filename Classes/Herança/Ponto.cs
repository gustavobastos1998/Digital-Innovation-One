using System;
namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }

        protected int CalcularDistancia2d(Ponto a)
        {
            double resultado , deltaX, deltaY, deltaXQ, deltaYQ;
            deltaX = Math.Abs(a.x - this.x);
            deltaY = Math.Abs(a.y - this.y);
            deltaXQ = Math.Pow(deltaX, 2);
            deltaYQ = Math.Pow(deltaY, 2);
            resultado = Math.Sqrt(deltaXQ + deltaYQ);
            return (int)resultado; 
        }
        public virtual void CalcularDistancia()
        {
            // faz algo
        }
    }
}
