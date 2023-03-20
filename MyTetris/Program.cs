using System.Globalization;
using System.Runtime.CompilerServices;
using static Tetriminos;

enum STARTSELECT
{
    GAMESELECT,
    NONESELECT
}

class Program
{
    public static void Ingame()
    {
        Map Map = new Map();
        Map.CreateMap();
        Tetriminos Tetriminos = new Tetriminos();
        while (true)
        {
            TETRIMINOS mTetriminos = new TETRIMINOS();
            int[] ArrNum = Tetriminos.GetGroup();
            int x;
            int y;
            int newx;
            int newy;
            for (int i = 0; i < 7; i++)
            {
                GoToxy(12, 0);
                mTetriminos = Tetriminos.CreateTetriminos(ArrNum[i]);
                (x, y) = Console.GetCursorPosition();
                Tetriminos.DrawTetriminos(mTetriminos, x, y);
                (newx, newy) = Tetriminos.MoveTetriminos(x, y);
                GoToxy(newx, newy);
                Console.ReadKey();
            }
        }
    }

    public static void GoToxy(int x, int y)
    {
        Console.SetCursorPosition(x, y);
    }

    static void Main(string[] args)
    {
        Commend GameSentence = new Commend();
        STARTSELECT StartSelect = new STARTSELECT();

        StartSelect = STARTSELECT.NONESELECT;
        while (true)
        {
            if (StartSelect == STARTSELECT.NONESELECT)
            {
                GameSentence.StartMessage();
                if (ConsoleKey.Enter == Console.ReadKey().Key)
                {
                    StartSelect = STARTSELECT.GAMESELECT;
                }
            }

            else
            {
                Console.Clear();
                Ingame();
                Console.ReadKey();
            }
        }
    }
}
