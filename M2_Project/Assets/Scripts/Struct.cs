


[System.Serializable]

public struct Stat
{
    //le statische
    public int atk;
    public int def;
    public int res;
    public int spd;
    public int aim;
    public int eva;
    public int crit;

    //costruttore
    public Stat(int attacco, int difesa, int resistenza, int velocita, int mira, int evasione, int critico)
    {
        atk = attacco;
        def = difesa;
        res = resistenza;
        spd = velocita;
        aim = mira;
        eva = evasione;
        crit = critico;

    }

    public static Stat Sum(Stat statA, Stat statB)
    {

        Stat result= new Stat();
        result.atk = statA.atk + statB.atk;
        result.def = statA.def + statB.def;
        result.res = statA.res + statB.res;
        result.spd = statA.spd + statB.spd;
        result.aim = statA.aim + statB.aim;
        result.crit = statA.crit + statB.crit;
        result.eva = statA.eva + statB.eva;
        return result;


    }

   
}
public enum Element
{
    NONE = 0,
    Fire = 1,
    Ice = 2,
    Poison = 3,
    Lighting = 4
}
