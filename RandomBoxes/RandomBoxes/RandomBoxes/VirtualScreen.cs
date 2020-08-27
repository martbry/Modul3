using System;
using System.Collections.Generic;
using System.Text;

namespace RandomBoxes
{
    public class VirtualScreen
    {
        private VirtualScreenRow[] _rows;

        public VirtualScreen(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                _rows[i] = new VirtualScreenRow(width);
            }
        }

        public void Add(Box box)
        {
            for (int i = 0; i < _rows.Length; i++)
            {
                if (i == box.StartY)
                {
                    _rows[i].AddBoxTopRow(box.X, box.Width);
                }
                else if (i > box.StartY && i < box.EndY-1)
                {
                    _rows[i].AddBoxMiddleRow(box.X, box.Width);
                }
                else if (i == box.EndY)
                {
                    _rows[i].AddBoxBottomRow(box.X, box.Width);
                }
            }
            

        }

        public void Show()
        {
            foreach (var rad in _rows)
            {
                foreach (var celle in rad._cells)
                {
                    Console.Write(celle.GetCharacter());
                }

                Console.WriteLine();
            }
        }
    }
}
