using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] theGrid { get; set; }

        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i,j);

                }
            }
        }

        public bool IsSafe(int x, int y)
        {
            if ((x<8 && x>=0)&&(y < 8 && y >= 0)) {
                Console.WriteLine("pozice {0}.{1} je platna",x,y);
                return true;
            }
            else
            {
                Console.WriteLine("pozice {0}.{1} neni platna", x, y);
                return false;
            }
        }

        public void MarkNextLegalMove(Cell CurrentCell, string chessPiese)
        {
            //step 1
            for (int i = 0; i < Size; i++)
            {
                for (int j= 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

            //step 2
            switch (chessPiese)
            {
                case "Knight": //jezdec
                    if(IsSafe(CurrentCell.RowNumber + 2, CurrentCell.ColumnNumber + 1))
                        theGrid[CurrentCell.RowNumber + 2, CurrentCell.ColumnNumber + 1].LegalNextMove = true;
                    if(IsSafe(CurrentCell.RowNumber + 2, CurrentCell.ColumnNumber - 1))
                        theGrid[CurrentCell.RowNumber + 2, CurrentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafe(CurrentCell.RowNumber - 2, CurrentCell.ColumnNumber + 1))
                        theGrid[CurrentCell.RowNumber - 2, CurrentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafe(CurrentCell.RowNumber - 2, CurrentCell.ColumnNumber - 1)) 
                        theGrid[CurrentCell.RowNumber - 2, CurrentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafe(CurrentCell.RowNumber + 1, CurrentCell.ColumnNumber + 2)) 
                        theGrid[CurrentCell.RowNumber + 1, CurrentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (IsSafe(CurrentCell.RowNumber + 1, CurrentCell.ColumnNumber - 2)) 
                        theGrid[CurrentCell.RowNumber + 1, CurrentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (IsSafe(CurrentCell.RowNumber - 1, CurrentCell.ColumnNumber + 2)) 
                        theGrid[CurrentCell.RowNumber - 1, CurrentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (IsSafe(CurrentCell.RowNumber - 1, CurrentCell.ColumnNumber - 2)) 
                        theGrid[CurrentCell.RowNumber - 1, CurrentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;

                case "King": //král
                    break;

                case "Rook": //věž
                    break;

                case "Bishop": //Střelec
                    break;

                case "Queen": //královna
                    break;

                default:
                    break;
            }
            theGrid[CurrentCell.RowNumber, CurrentCell.ColumnNumber].CurrentlyOccupied = true;
        }
    }
}
