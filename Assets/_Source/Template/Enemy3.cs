using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : EnemyAttack
{
    Player attackContext;

    private Animator anim;
    public Enemy3(Animator anim)
    {
        this.anim = anim;
    }
    public override void Awake()
    {
        attackContext.OnAttack += OnPlayerAttack; //вроде всё правильно написал но всё равно Null Reference
    }
    public override void OnPlayerAttack()
    {
        anim.SetTrigger("Attack");

        attackContext.OnAttack -= OnPlayerAttack;
    }

}
