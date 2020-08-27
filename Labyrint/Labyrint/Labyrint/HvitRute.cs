using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrint
{
    class HvitRute : Rute
    {

        public HvitRute(Labyrint labyrint, int rad, int kolonne) : base(labyrint, rad, kolonne)
        {

        }

        public override char SignRepresentation()
        {
            return '.';
        }
    }
}
