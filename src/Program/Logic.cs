using Ucu.Poo.GameOfLife;

public class Logic
{
    public void NextGen(Board board)
    {
        int boardWidth = board.Width;
        int boardHeight = board.Height;

        bool[,] newBoard = new bool[boardHeight, boardWidth];
        
        bool[,] currentBoard = board.GetBoard();

        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;

                // Contar los vecinos vivos
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && currentBoard[j, i])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (currentBoard[y, x])
                {
                    aliveNeighbors--;
                }

                if (currentBoard[y, x] && aliveNeighbors < 2)
                {
                    newBoard[y, x] = false;
                }
                else if (currentBoard[y, x] && aliveNeighbors > 3)
                {
                    newBoard[y, x] = false;
                }
                else if (!currentBoard[y, x] && aliveNeighbors == 3)
                {
                    newBoard[y, x] = true;
                }
                else
                {
                    newBoard[y, x] = currentBoard[y, x];
                }
            }
        }

        // Actualizar el tablero en la instancia `Board`
        board.SetBoard(newBoard);
    }
}