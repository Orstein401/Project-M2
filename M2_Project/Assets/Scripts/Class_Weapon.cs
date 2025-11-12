
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

    public Weapon(string name, DamageType Dmg_Type, Element element, Stat BonuStat)
    {
        this.name = name;
        dmg_type= Dmg_Type;
        this.element = element;
        bonuStat = BonuStat;
    }
}

