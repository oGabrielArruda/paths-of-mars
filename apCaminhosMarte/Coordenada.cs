using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class Coordenada
    {
        private int x, y;

        public Coordenada(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override bool Equals (Object obj)
        {
            if (obj == null)
                return false;

            if (this == obj)
                return true;

            if (!this.GetType().Equals(obj.GetType()))
                return false;

            Coordenada coord = (Coordenada)obj;
            if (this.x != coord.x)
                return false;
            if (this.y != coord.y)
                return false;

            return true;
        }
    }
}
