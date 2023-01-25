using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private Animator[] enemyAnimator;
    [SerializeField] private Button[] buttons;

    [SerializeField] private GameObject[] enemies;
    private AttackPerformer attackPerformer;
    private EnemyAttackPerformer enemyAttackPerformer;
    void Awake()
    {
        attackPerformer = new AttackPerformer(playerAnimator, buttons);
        enemyAttackPerformer = new EnemyAttackPerformer(enemyAnimator, enemies,buttons);
        attackPerformer.Awake();
        enemyAttackPerformer.Awake();
    }

    private void Update()
    {
        attackPerformer.Update();
    }
}
