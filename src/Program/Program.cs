using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de FileReader para leer el tablero desde un archivo
            FileReader fileReader = new FileReader();
            Board initialBoard = fileReader.Read();

            // Crear la lógica para calcular la siguiente generación
            Logic logic = new Logic();

            // Crear la clase para imprimir el tablero
            PrintBoard printBoard = new PrintBoard(initialBoard, logic);

            // Iniciar la impresión continua del tablero y el cálculo de las generaciones
            printBoard.ImprimirContinuamente();
        }
    }
}
