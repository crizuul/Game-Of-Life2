namespace Ucu.Poo.GameOfLife
{
    /// <summary>
    /// Representa el tablero del juego.
    /// 
    /// SRP: la responsabilidad de esta clase es representar
    /// y proporcionar acceso al estado del tablero.
    /// 
    /// Expert: el tablero conoce sus propios datos, por lo que
    /// es experto en informar su ancho, alto y estado de sus células.
    /// </summary>
    public class Board
    {
        private readonly bool[,] cells;

        public Board(bool[,] cells)
        {
            this.cells = cells;
        }

        public int Width
        {
            get { return cells.GetLength(0); }
        }

        public int Height
        {
            get { return cells.GetLength(1); }
        }

        public bool GetCell(int x, int y)
        {
            return cells[x, y];
        }

        public void SetCell(int x, int y, bool value)
        {
            cells[x, y] = value;
        }
    }
}