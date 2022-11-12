using System;

namespace CalculadoraDeConsole.Classes
{
    public class Calculadora
    {
        public float NumX;
        public float NumY;

        public Calculadora(float numX, float numY)
        {
            NumX = numX;
            NumY = numY;
        }

        public void Soma()
        {
            // printf("\n%.2f + %.2f = %.2f\n", NumX, NumY, NumZ);
            // Era pra ficar mais compactor assim. Codigo em cima escrito em C
            Console.Clear();
            Console.Write(NumX);Console.Write(" + " + NumY);
            this.NumY = this.NumX + this.NumY;
            Console.WriteLine(" = " + NumY);
        }

        public void Subtrai()
        {
            Console.Clear();
            Console.Write(NumX);Console.Write(" - " + NumY);
            this.NumY = this.NumX - this.NumY;
            Console.WriteLine(" = " + NumY);
        }

        public void Multiplica()
        {
            Console.Clear();
            Console.Write(NumX);Console.Write(" x " + NumY);
            this.NumY = this.NumX * this.NumY;
            Console.WriteLine(" = " + NumY);
        }

        public void Divide()
        {
            Console.Clear();
            Console.Write(NumX);Console.Write(" / " + NumY);
            this.NumY = this.NumX / this.NumY;
            Console.WriteLine(" = " + NumY);
        }

    }
}