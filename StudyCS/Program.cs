using System;

class Player
{
    private int hp;
    private int mp;
    private int lv = 1;
    public int Att;

    public void Move()
    {
        Console.WriteLine("Player is moving");
    }
    public void SetHP(int newHp)
    {
        hp = newHp;
    }

    public int GetLV()
    {
        return lv;
    }
}

namespace StudyCS
{ 
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Player Player1 = new Player();

            Player1.SetHP(10);
            Player1.Move();
            Console.WriteLine(Player1.GetLV());
        }
    }
}

