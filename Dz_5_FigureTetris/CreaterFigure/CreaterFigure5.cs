using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    class CreaterFigure5 : CreaterFigureFactory
    {
        public override IFigure createFigureFactory()
        {
            Figure5 membership = new Figure5();
            return membership;
        }
    }
}
