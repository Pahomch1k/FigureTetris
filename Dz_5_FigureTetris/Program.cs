using System;
using static System.Console;


namespace Dz_5_FigureTetris
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            while (flag == 0)
            {
                WriteLine("1. - Figure1\n" +
               "2. - Figure2\n" +
               "3. - Figure3\n" +
               "4. - Figure4\n" +
               "5. - Figure5\n" +
               "6. - Figure6\n" +
               "7. - Exit");

                int membershipType = Convert.ToInt32(ReadLine());
                if (membershipType == 7) flag++;
                else
                {
                    CreaterFigureFactory factory = GetFactory(membershipType);
                    IFigure membership = factory.createFigureFactory();

                    WriteLine($"Name:{membership.Name}\n" + $"Color:{membership.Color}\n");

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++) Write($"{membership.F[i, j]} ");
                        WriteLine();
                    }
                }
            } 
        }

        private static CreaterFigureFactory GetFactory(int membershipType) =>
        membershipType switch
        {
           1 => new CreaterFigure1(),
           2 => new CreaterFigure2(),
           3 => new CreaterFigure3(),
           4 => new CreaterFigure4(),
           5 => new CreaterFigure5(),
           6 => new CreaterFigure6(), 
            _ => null
        };
    }
}
