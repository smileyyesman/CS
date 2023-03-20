using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tetriminos
{
    public void GoToxy(int x, int y)
    {
        Console.SetCursorPosition(x, y);
    }
    public enum TETRIMINOS
    {
        O_TETRIMINO,
        I_TETRIMINO,
        Z_TETRIMINO,
        S_TETRIMINO,
        L_TETRIMINO,
        J_TETRIMINO,
        T_TETRIMINO
    }

    public int[] GetGroup()
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
        Random rnd = new Random();
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            int j = rnd.Next(i + 1);
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
        return numbers;
    }

    public TETRIMINOS CreateTetriminos(int _ArrNum)
    {
        switch (_ArrNum)
        {
            case 0:
                return TETRIMINOS.O_TETRIMINO;
            case 1:
                return TETRIMINOS.I_TETRIMINO;
            case 2:
                return TETRIMINOS.Z_TETRIMINO;
            case 3:
                return TETRIMINOS.S_TETRIMINO;
            case 4:
                return TETRIMINOS.L_TETRIMINO;
            case 5:
                return TETRIMINOS.J_TETRIMINO;
            case 6:
                return TETRIMINOS.T_TETRIMINO;
            default:
                return TETRIMINOS.O_TETRIMINO;
        }

    }

    public void DrawTetriminos(TETRIMINOS _mTetriminos, int _x, int _y)
    {
        (_x, _y) = Console.GetCursorPosition();
        switch (_mTetriminos)
        {
            case TETRIMINOS.O_TETRIMINO:
                Draw_O_Tetriminos();
                break;
            case TETRIMINOS.I_TETRIMINO:
                Draw_I_Tetriminos();
                break;
            case TETRIMINOS.Z_TETRIMINO:
                Draw_Z_Tetriminos();
                break;
            case TETRIMINOS.S_TETRIMINO:
                Draw_S_Tetriminos();
                break;
            case TETRIMINOS.L_TETRIMINO:
                Draw_L_Tetriminos();
                break;
            case TETRIMINOS.J_TETRIMINO:
                Draw_J_Tetriminos();
                break;
            case TETRIMINOS.T_TETRIMINO:
                Draw_T_Tetriminos();
                break;
            default:
                break;
        }
    }

    public (int, int) MoveTetriminos(int _x, int _y)
    {
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.RightArrow:
                return (_x + 1, _y);
            case ConsoleKey.LeftArrow:
                return (_x - 1, _y);
            case ConsoleKey.DownArrow:
                return (_x, _y + 1);
                /*
            case ConsoleKey.Spacebar:
                break;
            case ConsoleKey.Z:
                break;
            case ConsoleKey.X:
                break;
            default:
                break;
                */
        }

    }

    public void Draw_O_Tetriminos()
    {
        Console.WriteLine("■");
        /*
        (int x, int y) = Console.GetCursorPosition();
        Console.WriteLine(x.ToString());
        Console.WriteLine("■");
        GoToxy(x - 1, y);
        Console.WriteLine("■");
        GoToxy(x - 1, y + 1);
        Console.WriteLine("■");
        GoToxy(x, y + 1);
        Console.WriteLine("■");
        GoToxy(x, y);
        Console.WriteLine(x.ToString());
        */
    }
    public void Draw_I_Tetriminos()
    {
        Console.WriteLine("■");
    }
    public void Draw_Z_Tetriminos()
    {
        Console.WriteLine("■");
    }
    public void Draw_S_Tetriminos()
    {
        Console.WriteLine("■");
    }
    public void Draw_L_Tetriminos()
    {
        Console.WriteLine("■");
    }
    public void Draw_J_Tetriminos()
    {
        Console.WriteLine("■");
    }
    public void Draw_T_Tetriminos()
    {
        Console.WriteLine("■");
    }
}

