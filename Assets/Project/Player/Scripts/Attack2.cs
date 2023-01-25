using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : IAttackStrategy
{
    AttackContext attackContext;
    public void Attack(Animator anim)
    {
        anim.SetTrigger("Attack2");
    }
}
