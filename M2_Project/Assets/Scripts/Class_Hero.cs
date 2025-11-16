using UnityEngine;
[System.Serializable]

public class Hero
{
    [SerializeField]private string name;
    [SerializeField] private int hp;
    [SerializeField] private Stat baseStat;
    [SerializeField] private Element resistence;
    [SerializeField] private Element weakness;
    [SerializeField] private Element affinity; // indica con quale elemento è in sintonia l'eroe
    [SerializeField] private Weapon weapon;

    public Hero(string name, int hp, Stat baseStat, Element resistence, Element weakness,Element affinty, Weapon weapon)
    {
        this.name = name;
        this.hp = hp;
        this.baseStat = baseStat;
        this.resistence = resistence;
        this.weakness = weakness;
        this.affinity = affinty;
        this.weapon = weapon;

    }

    public string Name
    {
        get => name;
        set => name = value;
    }
    public int Hp => hp;
    public Stat BaseStat
    {
        get => baseStat;
        set => baseStat = value;
    }
    public Element Resistence
    {
        get => resistence;
        set => resistence = value;
    }
    public Element Weakness
    {
        get => weakness;
        set => weakness = value; 
        
    }

    public Element Affinity
    {
        get => affinity;
        set => affinity = value;
    }
    public Weapon Weapon
    {
        get => weapon;
        set => weapon = value;
    }

    public void SetHp(int newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else
        {
            hp = newHp;
        }
    }
    public void AddHp(int hp)
    {
        SetHp(this.hp += hp);

    }
    public void TakeDamage(int damage)
    {
        AddHp(-damage);
    }

    public bool IsAlive()
    {
        return hp > 0;
    }

}