using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySwitcher
{
    private GameObject[] enemies;
    private GameObject spawnedEnemy;
    private EnemyAttack enemyAttack;

    public EnemySwitcher(EnemyAttack enemyAttack, GameObject[] enemies)
    {
        this.enemies = enemies;
        this.enemyAttack = enemyAttack;
    }
    public void SwitchEnemy()
    {
        switch (enemyAttack)
        {
            case Enemy1: //Я так и не понял почему не работает Destroy (((((
                {
                    if (spawnedEnemy != null)
                    {
                        GameObject.Destroy(spawnedEnemy);
                    }
                    GameObject.Instantiate(enemies[0]);
                    spawnedEnemy = GameObject.FindGameObjectWithTag("Enemy");
                    Debug.Log(spawnedEnemy.name);
                    enemyAttack.Attack();
                }
                break;
            case Enemy2:
                {
                    if (spawnedEnemy != null)
                    {
                        GameObject.Destroy(spawnedEnemy);
                    }
                    GameObject.Instantiate(enemies[1]);
                    spawnedEnemy = GameObject.FindGameObjectWithTag("Enemy");
                    Debug.Log(spawnedEnemy.name);
                    enemyAttack.Attack();
                }
                break;
            case Enemy3:
                {
                    if (spawnedEnemy != null)
                    {
                        GameObject.Destroy(spawnedEnemy);
                    }
                    GameObject.Instantiate(enemies[2]);
                    spawnedEnemy = GameObject.FindGameObjectWithTag("Enemy"); 
                    Debug.Log(spawnedEnemy.name);
                    enemyAttack.Attack();
                }
                break;
        }
    }
}
