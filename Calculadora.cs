namespace EspacioCalculadora{
    public class Calculadora{
        private double dato = 0;
        public double resultado { get => dato;}

        void Sumar(double termino){ dato+=termino; }
        void Restar(double termino){ dato-=termino; }
        void Multiplicar(double termino){ dato*=termino; }
        void Dividir(double termino){
            if(termino!=0){
                dato/=termino;
            }
        }
        void Limpiar(double termino){ dato=0; }
    }
}