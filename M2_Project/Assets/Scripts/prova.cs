using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour
{
   Stat a=new Stat(10,10,10,10,10,10,10);
    void Start()
    {
        Weapon spear = new Weapon("lancia",DamageType.Physical,Element.Lighting,a);
        Weapon spear2 = new Weapon("lancia", DamageType.Physical, Element.Fire, a);

        Stat baseStat = new Stat(1000,10,10,50,40,60,0);
        Stat baseStat2 = new Stat(90, 10, 9, 70, 60, 40, 0);
        Hero BIMBO = new Hero("ddd", 1000, baseStat, Element.Lighting, Element.Fire,spear);
        Hero gino = new Hero("gino", 1200, baseStat2, Element.Fire , Element.NONE, spear2);

       

        int damage = GameFormulas.CalculateDamage(BIMBO,gino);
       
        Debug.Log("vita gino" + gino.Hp);
        Debug.Log(damage);
        gino.TakeDamage(damage);
        Debug.Log("vita gino" + gino.Hp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
