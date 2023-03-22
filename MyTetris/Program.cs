using System.Globalization;

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
        while (true)
        {
            Tetriminos Tetriminos = new Tetriminos();
            GoToxy(12, 0);
            /*
            for(int i = 0; i < 7; i++)
            {
                int[] ArrNum = Tetriminos.GetGroup();
                switch (ArrNum)
                {
                    case 0:

                    case 1:

                    case 2:

                    case 3:

                    case 4:

                    case 5:

                    case 6:

                    default:
                        break;
                }
            }
            */
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
