using System;
namespace Calculadora{
class Program
{
    static void Main(string[] args){
        Console.WriteLine("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escolha a operação: ");
        Console.WriteLine("1-Soma");
        Console.WriteLine("2-Subtração");
        Console.WriteLine("3-multiplicação");
        Console.WriteLine("4-divisão");

        int op = Convert.ToInt32(Console.ReadLine());
        int resultado = 0;

        switch (op)
        {
            case 1:
            resultado = numero1 + numero2;
            break;
            case 2:
            resultado = numero1 - numero2;
            break;
            case 3:
            resultado = numero1 * numero2;
            break;
            case 4: 
            resultado = numero1 / numero2;
            break;
            default:
             Console.WriteLine("Operação inválida.");
             break;
        }

        Console.WriteLine("O resultado é: " + resultado);




    }
}
}