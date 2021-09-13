namespace Revisão
{
    public struct Aluno // deveria ser uma classe, orém o exemplo é muito simples
    {
        private string name;
        private decimal nota;
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public decimal Nota 
        { 
            get => nota; 
            set => nota = value;
        }
    }
}