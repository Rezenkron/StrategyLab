using System;
using UnityEngine;

public class Player
{
    private readonly Animator anim;
    private IAttackStrategy attackStrategy;
    public event Action OnAttack;
    public Player(Animator anim)
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
