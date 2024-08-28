using System;

namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        private bool[,] _gameBoard;
        public int Width { get; }
        public int Height { get; }

        public Board(bool[,] initialBoard)
        {
            Height = initialBoard.GetLength(0);
            Width = initialBoard.GetLength(1);
            _gameBoard = new bool[Height, Width];
            Array.Copy(initialBoard, _gameBoard, initialBoard.Length);
        }

        public bool[,] GetBoard()
        {
            return _gameBoard;
        }

        public bool SetBoard(bool[,] newBoard)
        {
            if (newBoard.GetLength(0) == Height && newBoard.GetLength(1) == Width)
            {
                _gameBoard = newBoard;
                return true;
            }
            return false;
        }

        public bool GetCellState(int x, int y)
        {
            return _gameBoard[x, y];
        }

        public void SetCellState(int x, int y, bool state)
        {
            _gameBoard[x, y] = state;
        }
    }
}