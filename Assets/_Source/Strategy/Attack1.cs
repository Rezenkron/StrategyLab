using UnityEngine;

public class Attack1 : IAttackStrategy
{
    public void Attack(Animator anim)
    {
        anim.SetTrigger(HashedAnimations.Attack1);
    }
}
