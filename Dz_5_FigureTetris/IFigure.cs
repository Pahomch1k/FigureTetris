using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    interface IFigure
    {
        string Name { get; }
        string Color { get; }
        int[,] F { get; }
    }
}
