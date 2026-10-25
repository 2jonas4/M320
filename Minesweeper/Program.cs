using System;
using System.ComponentModel.Design;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 5;
            int colCount = 5;
            Cell[,] minefield = new Cell[rowCount, colCount];

            for (int i = 0; i < minefield.GetLength(0); i++)
            {
                for (int k = 0; k < minefield.GetLength(1); k++)
                {
                    minefield[i, k] = new Cell();
                }
            }

            while (true)
            {
                Console.Clear();
                PrintBoard(minefield);

                Console.WriteLine("Bitte Feld eingeben: ");
                var field = Console.ReadLine();

                if (string.Equals(field, "q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                RevealedField(minefield, field);
            }
        }

        static void PrintBoard(Cell[,] board)
        {
            Console.Write("  ");
            for (int i = 0; i < board.GetLength(1); i++)
            {
                Console.Write($"{i + 1} ");
            }
            Console.WriteLine();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write($"{(char)(65 + i)} ");
                for (int k = 0; k < board.GetLength(1); k++)
                {
                    if (!board[i, k].IsRevealed)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void RevealedField(Cell[,] board, string field)
        {
            // C2
            if (string.IsNullOrWhiteSpace(field) || field.Length < 2)
            {
                Console.WriteLine("Ungültige Eingabe. Beispiel: A1");
                return;
            }

            // Row: first character
            char rowChar = char.ToUpper(field[0]);
            if (rowChar < 'A' || rowChar > 'Z')
            {
                Console.WriteLine("Ungültige Zeile. Verwende Buchstaben A-Z.");
                return;
            }

            int row = rowChar - 'A';

            // Column: remaining characters
            var colPart = field.Substring(1);
            if (!int.TryParse(colPart, out int colNumber))
            {
                Console.WriteLine("Ungültige Spalte. Verwende eine Zahl, z.B. 1.");
                return;
            }

            int col = colNumber - 1;

            // Bounds checks
            if (row < 0 || row >= board.GetLength(0) || col < 0 || col >= board.GetLength(1))
            {
                Console.WriteLine("Feld außerhalb des Spielfelds.");
                return;
            }

            // Safe to reveal
            board[row, col].IsRevealed = true;
        }
    }

    public class Cell
    {
        public bool IsRevealed { get; set; }

        public bool HasMine {  get; set; }
        public bool IsFlagged { get; set; }
    }
}