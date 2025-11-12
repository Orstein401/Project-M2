
using UnityEngine;



public class Project_Test : MonoBehaviour
{

    [SerializeField] Hero hero1;
    [SerializeField] Hero hero2;


    void Update()
    {

        if (hero1.IsAlive() != false && hero2.IsAlive() != false)
        {
            if (hero1.BaseStat.spd + hero1.Weapon.BonusStat.spd > hero2.BaseStat.spd + hero2.Weapon.BonusStat.spd)
            {
                
                GameFormulas.Attacking(hero1, hero2);
            }
            else
            {
               
                GameFormulas.Attacking(hero2, hero1);

            }
        }
        else
        {
            return;
        }

    }
}
