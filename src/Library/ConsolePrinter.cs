using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    /// <summary>
    /// Muestra un tablero por consola.
    ///
    /// SRP: su única responsabilidad es mostrar el tablero.
    ///
    /// Expert: esta clase sabe cómo representar el tablero
    /// visualmente en la consola.
    /// </summary>
    public class ConsolePrinter
    {
        public void Print(Board board)
        {
            StringBuilder result = new StringBuilder();

            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    if (board.GetCell(x, y))
                    {
                        result.Append("|X|");
                    }
                    else
                    {
                        result.Append("___");
                    }
                }

                result.AppendLine();
            }

            Console.WriteLine(result.ToString());
        }
    }
}