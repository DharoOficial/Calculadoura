namespace Calculadoura
{
    public class Calculadora
    {
        public int valor1 { get; set; }
        public int valor2 { get; set; }
        public float resultado { get; set; }
        public void Somar(){
            resultado = valor1 + valor2;
        }
        public void Subtrair(){
            resultado = valor1 - valor2;
        }
        public void Multiplicar(){
            resultado = valor1 * valor2;
        }
        public void Dividir(){
            resultado = valor1 / valor2;
        }
    }
}