using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAttack
{
    public void Attack() //� �� �������� �������� � ������ ������ ����������� ������ ��� ������� �����
    {
        Awake();
        Update();
        OnPlayerAttack();
    }
    
    public virtual void Awake() { }
    public virtual void OnPlayerAttack() { }
    public virtual void Update() { } //�� �������� ��� �� ������ ��������
}
