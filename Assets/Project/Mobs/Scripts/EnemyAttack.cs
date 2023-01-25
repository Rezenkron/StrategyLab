using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAttack
{
    public void Attack() //я не придумал алгоритм и просто сделал виртуальные методы для каждого врага
    {
        Awake();
        Update();
        OnPlayerAttack();
    }
    
    public virtual void Awake() { }
    public virtual void OnPlayerAttack() { }
    public virtual void Update() { } //не придумал как он должен работать
}
