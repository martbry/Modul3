using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrint
{
    abstract class Rute
    {

        public Labyrint Belongsto { get; }

        public int Rowcoordinate { get; }
        public int Columncoordinate { get; }

        public Rute NeighbourNorth { get; set; }
        public Rute NeighbourSouth { get; set; }
        public Rute NeighbourWest { get; set; }
        public Rute NeighbourEast { get; set; }


        protected Rute(Labyrint labyrint, int rad, int kolonne)
        {
            Belongsto = labyrint;
            Rowcoordinate = rad;
            Columncoordinate = kolonne;
        }


        public abstract char SignRepresentation();
    }
}