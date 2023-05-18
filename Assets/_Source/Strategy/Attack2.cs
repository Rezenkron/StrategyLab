using UnityEngine;

public class Attack2 : IAttackStrategy
{
    Player attackContext;
    public void Attack(Animator anim)
    {
        anim.SetTrigger(HashedAnimations.Attack2 );
    }
}
