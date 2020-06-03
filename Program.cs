using System;

namespace Calculadoura
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica start = new CalculadoraCientifica();
            bool loop;
            int numeros = 0;
            int i = 0;

            int a = 6;

    System.Console.WriteLine("digite 1 para somar 2 para subtrair 3 para multiplicar, 4 para dividir e 5 para pegar uma media.");
switch(
    a = int.Parse(Console.ReadLine())
    )
    {
    case 1:
    System.Console.WriteLine("digite o primeiro valor.");
    start.valor1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("digite o segundo valor valor.");
    start.valor2 = int.Parse(Console.ReadLine());
    start.Somar();
    System.Console.WriteLine(start.resultado);
        
        break;

    case 2:
    System.Console.WriteLine("digite o primeiro valor.");
    start.valor1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("digite o segundo valor valor.");
    start.valor2 = int.Parse(Console.ReadLine());
    start.Subtrair();
    System.Console.WriteLine(start.resultado);
        
        break;

    case 3:
    System.Console.WriteLine("digite o primeiro valor.");
    start.valor1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("digite o segundo valor valor.");
    start.valor2 = int.Parse(Console.ReadLine());
    start.Multiplicar();
    System.Console.WriteLine(start.resultado);
        
        break;

    case 4:
    System.Console.WriteLine("digite o primeiro valor.");
    start.valor1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("digite o segundo valor valor.");
    start.valor2 = int.Parse(Console.ReadLine());
    start.Dividir();
    System.Console.WriteLine(start.resultado);
        
        break;

        case 5:
            int[] media = new int[9];

            System.Console.WriteLine("digite (true) para iniciar o calculo da media. ");
            loop = bool.Parse(Console.ReadLine());
            
            while( loop == true){
            numeros++;
            System.Console.WriteLine("digite um numero");
            media[i] = int.Parse(Console.ReadLine());
            i++;
            System.Console.WriteLine("deseja adicionar outro numero (true) para sim (false) para nao");
            loop = bool.Parse(Console.ReadLine());
            }
            
            
                 
            start.media = media[0]
                + media[1]
                + media[2]
                + media[3]
                + media[4]
                + media[5]
                + media[6]
                + media[7]
                + media[8]
                + media[9]
                / numeros;
                System.Console.WriteLine(start.media);
        

        break;

    default:
            
        break;


}

        }
    }
}
