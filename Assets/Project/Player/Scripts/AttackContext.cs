using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AttackContext
{
    private Animator anim;
    private IAttackStrategy attackStrategy;
    public event Action OnAttack;
    public AttackContext(Animator anim)
    {
        this.anim = anim;
    }

    public void SetStrategy(IAttackStrategy attackStrategy)
    {
        this.attackStrategy = attackStrategy;
    }

    public void PerformAttack()
    {
        attackStrategy.Attack(anim);
        OnAttack?.Invoke();
    }

}
