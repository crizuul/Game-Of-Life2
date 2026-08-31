using System.IO;

namespace Ucu.Poo.GameOfLife
{
    /// <summary>
    /// Lee un tablero desde un archivo de texto.
    ///
    /// SRP: esta clase tiene una única responsabilidad:
    /// obtener la información del tablero desde un archivo.
    ///
    /// Expert: BoardReader conoce cómo interpretar el archivo
    /// y transformarlo en un objeto Board.
    /// </summary>
    public class BoardReader
    {
        public Board Read(string path)
        {
            string content = File.ReadAllText(path);

            string[] lines = content
                .Replace("\r", "")
                .TrimEnd('\n')
                .Split('\n');

            bool[,] cells = new bool[lines[0].Length, lines.Length];

            for (int y = 0; y < lines.Length; y++)
            {
                for (int x = 0; x < lines[y].Length; x++)
                {
                    if (lines[y][x] == '1')
                    {
                        cells[x, y] = true;
                    }
                }
            }

            return new Board(cells);
        }
    }
}