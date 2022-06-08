using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    class CreaterFigure3 : CreaterFigureFactory
    {
        public override IFigure createFigureFactory()
        {
            Figure3 membership = new Figure3();
            return membership;
        }
    }
}
