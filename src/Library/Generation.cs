namespace Ucu.Poo.GameOfLife
{
    /// <summary>
    /// Calcula la siguiente generación del juego
    ///
    /// SRP: la única responsabilidad es aplicar las reglas
    /// del Game of Life para obtener el siguiente tablero
    ///
    /// Expert: esta clase conoce las reglas necesarias para
    /// calcular la siguiente generación
    /// </summary>
    public class Generation
    {
        public Board Next(Board board)
        {
            bool[,] newCells = new bool[board.Width, board.Height];

            for (int x = 0; x < board.Width; x++)
            {
                for (int y = 0; y < board.Height; y++)
                {
                    int aliveNeighbors = CountAliveNeighbors(board, x, y);

                    bool alive = board.GetCell(x, y);

                    if (alive && aliveNeighbors < 2)
                    {
                        newCells[x, y] = false;
                    }
                    else if (alive && aliveNeighbors > 3)
                    {
                        newCells[x, y] = false;
                    }
                    else if (!alive && aliveNeighbors == 3)
                    {
                        newCells[x, y] = true;
                    }
                    else
                    {
                        newCells[x, y] = alive;
                    }
                }
            }

            return new Board(newCells);
        }

        private static int CountAliveNeighbors(Board board, int x, int y)
        {
            int count = 0;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 &&
                        i < board.Width &&
                        j >= 0 &&
                        j < board.Height &&
                        board.GetCell(i, j))
                    {
                        count++;
                    }
                }
            }

            if (board.GetCell(x, y))
            {
                count--;
            }

            return count;
        }
    }
}