using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Map
{
    private void GoToxy(int x, int y)
    {
        Console.SetCursorPosition(x, y);
    }
    public void CreateMap()
    {
        for (int i = 0; i < 22; i++)
        {
            GoToxy(0, i);
            Console.Write("□");
            GoToxy(22, i);
            Console.Write("□");
        }
        for (int i = 0; i <= 22; i += 2)
        {
            GoToxy(i, 22);
            Console.Write("□");
        }

    }
}

