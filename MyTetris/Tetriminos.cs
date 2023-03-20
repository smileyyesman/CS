using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Tetriminos
{
    enum TETRIMINOS
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
    
}

