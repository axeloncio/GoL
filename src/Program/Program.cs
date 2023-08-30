using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {

            var read = new Read();
            Matriz gameBoard = new Matriz(read.CreateBoard());
            Show.Imprimir(gameBoard);
        }
    }
}
