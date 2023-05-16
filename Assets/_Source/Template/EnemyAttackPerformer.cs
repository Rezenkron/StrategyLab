using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttackPerformer
{
    private GameObject[] enemies;
    private Animator[] anim;

    private EnemyAttack enemy1;
    private EnemyAttack enemy2;
    private EnemyAttack enemy3;
    private EnemySwitcher enemySwitcher;

    public EnemyAttackPerformer(Animator[] anim, GameObject[] enemies, Button[] buttons)
    {
        this.anim = anim;
        this.enemies = enemies;
        buttons[0].onClick.AddListener(EnemyOne);
        buttons[1].onClick.AddListener(EnemyTwo);
        buttons[2].onClick.AddListener(EnemyThree);
    }

    public void Awake()
    {
        enemy1 = new Enemy1(anim[0]);
        enemy2 = new Enemy2(anim[1]);
        enemy3 = new Enemy3(anim[2]);
    }

    public void EnemyOne()
    {
        enemySwitcher = new EnemySwitcher((Enemy1)enemy1, enemies);
        enemySwitcher.SwitchEnemy();
    }

    public void EnemyTwo()
    {
        enemySwitcher = new EnemySwitcher((Enemy2)enemy2, enemies);
        enemySwitcher.SwitchEnemy();
    }

    public void EnemyThree()
    {
        enemySwitcher = new EnemySwitcher((Enemy3)enemy3, enemies);
        enemySwitcher.SwitchEnemy();
    }




}
