using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : EnemyAttack
{
    private Animator anim;
    public Enemy1(Animator anim)
    {
        this.anim = anim;
    }

    public override void Awake()
    {
        anim.SetTrigger("Attack");
    }
}
