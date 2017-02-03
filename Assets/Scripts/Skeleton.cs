using UnityEngine;
using System.Collections;
using System;
public class Skeleton : Enemy
{
    public override void attack()
    {
        isAttack = false;
        if (!isAttackrange)
            return;
        player.GetComponent<PlayerStats>().Health -= 3;
        
    }

    public override void takeDamege()
    {
      
        this.health -= 10;
    }
    public override int getHealth()
    {
        return health;
    }
    public override void die()
    {
        isAlive = false;

    }
    void Update()
    {
        CheckAttack();
        if (isAlive == false)
            Destroy(this);
    }

}
