using UnityEngine;

public class Attack3 : IAttackStrategy
{
    public void Attack(Animator anim)
    {
        anim.SetTrigger(HashedAnimations.Attack3);
    }
}
