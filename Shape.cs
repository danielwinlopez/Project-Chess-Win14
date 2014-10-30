using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public abstract class Shape
    {
        protected Position StartPosition;

        public virtual void Draw()
        {
        }
    }
}
