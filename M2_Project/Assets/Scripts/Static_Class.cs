
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public static class GameFormulas
{
    static bool HasElementAdvatange(Element attackElement, Hero defender)
    {
        return attackElement == defender.Weakness;
    }
    static bool HasElementDisadvatange(Element attackElement, Hero defender)
    {
        return attackElement == defender.Resistence;
    }

    static float EvaluateElementalModifier(Element attackElement, Hero defender)
    {
        if (HasElementAdvatange(attackElement, defender))
        {
            Debug.Log("WEAkNESS");
            return 1.5f;
        }
        else if (HasElementDisadvatange(attackElement, defender))
        {
            Debug.Log("RESISTENCE");
            return 0.5f;
        }
        else
        {
            return 1f;
        }
    }

    public static bool HasHit(Stat attacker, Stat defender)
    {
        int chanceHit = defender.eva  - attacker.aim;
        int hitPoint = Random.Range(0, 100); // sta per punteggio hit, per indicare quanti punti servono per poter colpire
        if (chanceHit >= hitPoint)
        {
            Debug.Log("HIT");
            return true;
        }
        else
        {
            Debug.Log("MISS");
            return false;
        }

    }

    static bool HasCrit(int critValue)
    {
        int critPoint = Random.Range(0, 99);
        if (critPoint <= critValue)
        {
            Debug.Log("CRIT");
            return true;
        }
        else
        {
            return false;
        }

    }

    public static int CalculateDamage(Hero attacker, Hero defender)
    {
        Stat SommaStat1= Stat.Sum(attacker.BaseStat, attacker.Weapon.BonusStat);
        Stat SommaStat2= Stat.Sum(defender.BaseStat, defender.Weapon.BonusStat);


        int difesa;
        if (attacker.Weapon.DmgType == DamageType.Physical)
        {
            difesa = SommaStat2.def;
        }
        else
        {
            difesa = SommaStat2.res;

        }

        float damage = SommaStat1.atk - difesa;

        damage *= EvaluateElementalModifier(attacker.Weapon.Element, defender);
        
        if (HasCrit(SommaStat1.crit))
        {
            damage *= 2;
        }
       
        if (damage < 0)
        {
            return 0;
        }
        else
        {
            return Mathf.RoundToInt(damage);
        }
    }

    // funzione statica aggiuntiva per far si che tutta l'azione di attacco venga gestita qua

    public static void Attacking(Hero attacker, Hero defender)
    {
        Debug.Log($"{attacker.Name} attacca {defender.Name} si difende");

        if (GameFormulas.HasHit(attacker.BaseStat, defender.BaseStat))
        {
            int damage = CalculateDamage(attacker, defender);
            Debug.Log("danno inflitto" + damage);

            defender.TakeDamage(damage);
            Debug.Log($"{defender.Name} rimane con {defender.Hp}");
            if (defender.Hp <= 0)
            {
                Debug.Log($"{defender.Name} è stato sconfitto, il vincitore è {attacker.Name}");
                return;
            }
        }

        Debug.Log($"{defender.Name} attacca {attacker.Name} si difende");

        if (GameFormulas.HasHit(defender.BaseStat, attacker.BaseStat))
        {
            int damage = CalculateDamage(defender, attacker);
            Debug.Log("danno inflitto" + damage);

            attacker.TakeDamage(damage);
            Debug.Log($"{attacker.Name} rimane con {attacker.Hp}");
            if (attacker.Hp <= 0)
            {
                Debug.Log($"{attacker.Name} è stato sconfitto, il vincitore è {defender.Name}");
                return;
            }
        }
    }
}