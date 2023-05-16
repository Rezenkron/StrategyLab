using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : IAttackStrategy
{
    Player attackContext;
    public void Attack(Animator anim)
    {
        anim.SetTrigger("Attack2");
    }
}
