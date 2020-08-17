using System;
using System.Collections.Generic;
using System.Text;

namespace Regneklynge
{
    class Rack
    {

        public Node[] Noderack;

        public Rack(int storrelse)
        {
            Noderack = new Node[storrelse];
        }

        public bool IsFull()
        {
            foreach (Node n in Noderack)
            {
                if (n == null)
                {
                    return false;
                }
            }

            return true;
        }

        public void AddNode(Node node)
        {
            var indeks = 0;
            foreach (Node n in Noderack)
            {
                if (n == null)
                {
                    Noderack[indeks] = node;
                    return;
                }

                indeks++;
            }
        }
    }
}
