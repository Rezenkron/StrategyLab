using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : EnemyAttack
{
    Animator anim;
    public Enemy2(Animator anim)
    {
        this.anim = anim;
    }

    public override void Update()
    {
        anim.SetTrigger("Attack");
    }
}
