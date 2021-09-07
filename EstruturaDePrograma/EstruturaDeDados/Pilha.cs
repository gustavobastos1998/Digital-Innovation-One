using System;

namespace EstruturaDePrograma.EstruturaDeDados
{
    class Pilha
    {
        Posicao topo;

        public void push(object item)
        {
            topo = new Posicao(topo, item);
        }

        public object pop()
        {
            if (topo == null)
            {
                throw new InvalidOperationException();
            }
            object resultado = topo.getItem();
            topo = topo.getNext();
            return resultado;
        }

        class Posicao
        {
            private Posicao next;
            private object item;

            public Posicao(Posicao next, object item)
            {
                this.next = next;
                this.item = item;
            }
            
            public object getItem(){
                return item;
            }
            public Posicao getNext(){
                return next;
            }
        }
    }
}