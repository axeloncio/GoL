using System.IO;
using Microsoft.VisualBasic;

namespace PII_Game_Of_Life
{
  public class Read
  {
    private string url = @"../../assets/board.txt";
    private string[] contentLines;



    public bool[,] CreateBoard()
    {
      contentLines = ReadFile(); // Inicialización en el constructor
      bool[,] board = new bool[contentLines.Length, contentLines[0].Length];


      for (int y = 0; y < contentLines.Length; y++)
      {
        for (int x = 0; x < contentLines[y].Length; x++)
        {
          if (contentLines[y][x] == '1')
          {
            board[x, y] = true;
          }
        }
      }

      return board;
    }




    public string[] ReadFile()
    {
      string[] lines = File.ReadAllLines(url);
      return lines;
    }

  }
}