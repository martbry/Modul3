using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBoxes
{
    public class VirtualScreenRow
    {
        public VirtualScreenCell[] _cells; // accesses the fields in this class (not the values)

        public VirtualScreenRow(int screenWidth) // assigns values to the array (defaulted to null)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (int i = 0; i < screenWidth; i++)
            {
                _cells[i] = new VirtualScreenCell(); // in this case, the ctor creates objects 
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth) // takes two user-set params: shape and width (n vertical bars)
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (i == boxX)
                {
                    _cells[i].AddUpperLeftCorner();
                }
                else if (i == boxX + boxWidth - 1)
                {
                    _cells[i].AddUpperRightCorner();
                }
                else if (i > boxX && i < boxX + boxWidth-1)
                {
                    _cells[i].AddHorizontal();
                }
            }

        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (i == boxX)
                {
                    _cells[i].AddLowerLeftCorner();
                }
                else if (i == boxX + boxWidth - 1)
                {
                    _cells[i].AddLowerRightCorner();
                }
                else if (i > boxX && i < boxX + boxWidth -1)
                {
                    _cells[i].AddHorizontal();
                }
            }
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (i == boxX || i == boxX + boxWidth - 1)
                {
                    _cells[i].AddVertical();
                }
            }
        }

        public void Show()
        {
            //Console.CursorLeft = 0;
            var chars = _cells.Select(cell => cell.GetCharacter()).ToArray();
            Console.WriteLine(chars);
        }
    }
}
