using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrint
{
    class Labyrint
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        private Rute[,] Labyrinth { get; set; }


        private Labyrint(Rute[] ruter, int rader, int kolonner)
        {
            this.Rows = rader;
            this.Columns = kolonner;

            int ruteirekken = 0;

            for (int rad = 0; rad < this.Rows; rad++)
            {
                for (int kolonne = 0; kolonne < this.Columns; kolonne++)
                {
                    Labyrinth[kolonne, rad] = ruter[ruteirekken];
                    ruteirekken++;
                }
            }
        }

        static Labyrint ReadFromFile()
        {

        }

    }
}
