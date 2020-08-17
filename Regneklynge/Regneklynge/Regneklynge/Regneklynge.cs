using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Regneklynge
{
    class Regneklynge
    {

        public List<Rack> Rackliste = new List<Rack>();

        public int RackCount()
        {
            return Rackliste.Count;
        }


        public Rack NewRack(int storrelse)
        {
            return new Rack(storrelse);
        }

        public void InsertNode(int antallcpuer, int antallgbminne)
        {
            if (RackCount() == 0)
            {
                Rackliste.Add(NewRack(10));
                Rackliste[0].AddNode(new Node(antallcpuer, antallgbminne));
                return;
            }

            foreach (var rack in Rackliste)
            {
                if (!rack.IsFull())
                {
                    rack.AddNode(new Node(antallcpuer, antallgbminne));
                    return;
                }
            }

            Rackliste.Add(NewRack(10));
            InsertNode(antallcpuer, antallgbminne);

        }


    }

}
