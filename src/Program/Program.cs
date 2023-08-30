using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {

            var read = new Read();

            Matriz tablero = new Matriz(read.CreateBoard());


            foreach (var line in tablero.board)
            {
                Console.WriteLine(line);
            }

        }
    }
}
