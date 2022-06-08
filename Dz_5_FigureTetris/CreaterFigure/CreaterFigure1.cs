using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    class CreaterFigure1 : CreaterFigureFactory
    {   
        public override IFigure createFigureFactory()
        {
            Figure1 membership = new Figure1(); 
            return membership;
        }
    }
}
