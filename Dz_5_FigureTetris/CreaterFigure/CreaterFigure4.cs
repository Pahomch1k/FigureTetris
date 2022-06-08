using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    class CreaterFigure4 : CreaterFigureFactory
    {
        public override IFigure createFigureFactory()
        {
            Figure4 membership = new Figure4();
            return membership;
        }
    }
}
