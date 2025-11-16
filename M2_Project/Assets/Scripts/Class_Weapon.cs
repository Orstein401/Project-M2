
using UnityEngine;
[System.Serializable]

public enum DamageType
{
    Physical,
    Magical
}
[System.Serializable]

public class Weapon
{


    [SerializeField] private string name;
    [SerializeField] private DamageType dmg_type;
    [SerializeField] private Element element;
    [SerializeField] private Stat bonuStat;
    [SerializeField] private int range; // è una variabile che sta a indicare la lunghezza dell'arma, parte da 10 a 40 è corta, da 40+ a 70 è media e da 70+ fino a 100 è lunga



    public string Name
    {
        get => name;
        set => name = value;
    }
    public DamageType DmgType
    {
        get => dmg_type;
        set => dmg_type = value;
    }

    public Element Element
    {
        get => element;
        set => element = value;
    }
    public Stat BonusStat
    {
        get => bonuStat;
        set => bonuStat = value;
    }

    public int Range
    {
        get => range;
        // dentro al set controllo, se non sono state messe armi minuscole o gigantesche
        set
        {
            if (value <= 0)
            {
                range = 10;
            }
            else if (value > 100)
            {
                range = 100;
            }
            else
            {
                range = value;  
            }
        }
    }

    public Weapon(string name, DamageType Dmg_Type, Element element, Stat BonuStat, int range)
    {
        this.name = name;
        dmg_type = Dmg_Type;
        this.element = element;
        bonuStat = BonuStat;
        this.range = range;
    }
}

