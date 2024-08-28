using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()
        {
            FileRider fileRider = new FileRider();
            bool[,] initialBoard = fileRider.LeerArchivo("board.txt");
            Board board = new Board(initialBoard);
            Logic nuevaGeneracion = new Logic();
            PrintBoard printBoard = new PrintBoard(board, nuevaGeneracion);

            printBoard.ImprimirContinuamente();
        }
}
