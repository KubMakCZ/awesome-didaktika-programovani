using ChessBoardModel;
using System;

namespace ChessConsole
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            Console.WriteLine("Chess KI/DPG");

            printBoard(myBoard);

            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            myBoard.MarkNextLegalMove(currentCell, "Knight");

            printBoard(myBoard); 
        }

        private static Cell setCurrentCell()
        {
            Console.WriteLine("Enter current row number:");
            int currentRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter current collumn number:");
            int currentColumn = int.Parse(Console.ReadLine());

            //myBoard.theGrid[currentRow, currentColumn].CurrentlyOccupied = true;
            return myBoard.theGrid[currentRow, currentColumn];
        }

        public static void printBoard(Board myBoard) 
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true)
                    {
                        Console.Write("X");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("=================");
        }
    }
}
