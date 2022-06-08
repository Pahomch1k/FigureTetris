using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    class CreaterFigure6 : CreaterFigureFactory
    {
        public override IFigure createFigureFactory()
        {
            Figure6 membership = new Figure6();
            return membership;
        }
    }
}
