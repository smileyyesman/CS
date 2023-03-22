enum TYPE
{
    ATT,
    FIRE,
    WATER
}
class Player
{
    
    int ATTDef = 3;
    int FireDef = 4;
    int WaterDef = 5;
    int HP = 50;

    public void Damage(int _Dmg)
    {
        HP -= _Dmg;
    }
    public void Damage(int _Dmg, TYPE _type)
    {
        switch (_type)
        {
            case TYPE.ATT:
                _Dmg -= ATTDef;
                break;
            case TYPE.FIRE:
                _Dmg -= FireDef;
                break;
            case TYPE.WATER:
                _Dmg -= WaterDef;
                break;
            default:
                break;
        }
        Damage(_Dmg);

    }
}


internal class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NewPlayer.Damage(10, TYPE.ATT);
    }
}
