using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            var read = new Read();
            var board = read.ReadFile();

            foreach (var line in board)
            {
                Console.WriteLine(line);
            }

        }
    }
}
