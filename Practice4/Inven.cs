using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

class Inven
{
    Item[] ArrItem;
    int X;
    int Y;
    int SelectIndex = 0;
    public Inven(int _X, int _Y)
    {
        if (1 > _X || 1 > _Y)
        {
            _X = 1;
            _Y = 1;
        }
        X = _X;
        Y = _Y;
        ArrItem = new Item[_X * _Y];
    }

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (i != 0 && 0 == i % X)
            {
                Console.WriteLine("");
            }
            
            if (SelectIndex == i)
            {
                Console.Write("▣");
            }
            else if (null == ArrItem[i])
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("■");
            }            
        }

        while (true)
        {
            ConsoleKeyInfo KeyInfo = Console.ReadKey();

            switch (KeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (SelectIndex == 0)
                    {
                        SelectIndex = X * Y - 1;
                        return;
                    }
                    else
                    {
                        SelectIndex -= 1;
                        return;
                    }
                case ConsoleKey.RightArrow:
                    if (SelectIndex == X * Y - 1)
                    {
                        SelectIndex = 0;
                        return;
                    }
                    else
                    {
                        SelectIndex += 1;
                        return;
                    }
                case ConsoleKey.UpArrow:
                    if (SelectIndex < X)
                    {
                        SelectIndex += X * (Y - 1);
                        return;
                    }
                    else
                    {
                        SelectIndex -= X;
                        return;
                    }

                case ConsoleKey.DownArrow:
                    if (SelectIndex >= X * (Y - 1))
                    {
                        SelectIndex -= X * (Y - 1);
                        return;
                    }
                    else
                    {
                        SelectIndex += X;
                        return;
                    }
                default:
                    break;
            }

        }
    }   

    public void ItemIn(Item _Item)
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (null == ArrItem[i])
            {
                ArrItem[i] = _Item;
                break;
            }
        }
    }

    public void ItemIn(Item _Item, int _Index)
    {
        if (null != ArrItem[_Index])
        {
            return;
        }
        ArrItem[_Index] = _Item;
    }
}
