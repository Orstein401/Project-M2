
using UnityEngine;



public class Project_Test : MonoBehaviour
{

    [SerializeField] Hero hero1;
    [SerializeField] Hero hero2;


    void Update()
    {

        if (hero1.IsAlive() != false && hero2.IsAlive() != false)
        {
            // oltre al controllo se è semplicemnte più veloce tramite stat, aggiungo la lunghezza dell'arma, simulando il fatto che magari uno è più veloce
            // ma ha un arma corta, quidni quello più lento tramite la lunghezza dell'arma può anche attaccare per primo
            if (hero1.BaseStat.spd + hero1.Weapon.BonusStat.spd +hero1.Weapon.Range> hero2.BaseStat.spd + hero2.Weapon.BonusStat.spd+hero2.Weapon.Range)
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
