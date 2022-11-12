using System;
using CalculadoraDeConsole.Classes;

namespace CalculadoraDeConsole
{
    public class Program
    {
        public static void Main()
        {
            float ValorX, ValorY;
            char numSelect;

            Console.Clear(); // vai limpar o resto da sujeira antes de iniciar o codigo
            
            Console.WriteLine("Digite o primeiro valor: ");
            ValorX = float.Parse(Console.ReadLine());
            Console.WriteLine(("Digite o segundo valor: "));
            ValorY = float.Parse(Console.ReadLine());

            Calculadora calculadora01 = new Calculadora(ValorX, ValorY);

            Console.WriteLine("Digite a operação do qual quer fazer: ");
            Console.WriteLine(" | + | - | * | / | ");
            Console.WriteLine(" | Soma | Subtração | Multiplicação | Divisão | ");
            numSelect = Convert.ToChar(Console.ReadLine());

            if (numSelect == '+') // Chama a Soma
                calculadora01.Soma();
            
            else if (numSelect == '-') // Chama a Subtração
                calculadora01.Subtrai();
            
            else if (numSelect == '*') // Chama a Multiplicação
                calculadora01.Multiplica();
            else if (numSelect == 'x')
                calculadora01.Multiplica();
            
            else if (numSelect == '/') // Chama a Divisão
                calculadora01.Divide();
        }
    }
}