using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    public class PrintBoard
    {
        private Board _board;
        private Logic _nuevaGeneracion;

        public PrintBoard(Board board, Logic nuevaGeneracion)
        {
            _board = board;
            _nuevaGeneracion = nuevaGeneracion;
        }

        public void ImprimirContinuamente()
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                bool[,] b = _board.GetBoard();
                int width = _board.Width;
                int height = _board.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (b[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }

                Console.WriteLine(s.ToString());
                _board.SetBoard(_nuevaGeneracion.CalcularSiguienteGeneracion(b));
                Thread.Sleep(300);
            }
        }
    }
}