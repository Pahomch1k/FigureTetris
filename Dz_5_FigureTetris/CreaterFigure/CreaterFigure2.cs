using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    class CreaterFigure2 : CreaterFigureFactory
    {
        public override IFigure createFigureFactory()
        {
            Figure2 membership = new Figure2();
            return membership;
        }
    }
}
