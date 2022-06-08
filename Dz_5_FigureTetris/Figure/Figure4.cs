using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_FigureTetris
{
    class Figure4 : IFigure
    {
        private readonly string name;
        private readonly int[,] f;
        private readonly string color;

        public Figure4()
        {
            name = "Figure4";
            f = new int[4, 4] { { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 } };
            color = "Blue";
        }

        public string Name => name;
        public string Color => color;
        public int[,] F => f;
    }
}
