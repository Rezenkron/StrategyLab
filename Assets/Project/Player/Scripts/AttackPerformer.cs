using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AttackPerformer
{
    [SerializeField] private Animator _anim;
    [SerializeField] private Button[] _buttons;

    AttackContext attackContext;
    private Attack1 attack1;
    private Attack2 attack2;
    private Attack3 attack3;


    public AttackPerformer(Animator anim, Button[] buttons)
    {
        _anim = anim;
        _buttons = buttons;
        buttons[0].onClick.AddListener(Attack1);
        buttons[1].onClick.AddListener(Attack2);
        buttons[2].onClick.AddListener(Attack3);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            attackContext.PerformAttack();
        }
    }

    public void Awake()
    {
        attackContext = new AttackContext(_anim);
        attack1 = new Attack1();
        attack2 = new Attack2();
        attack3 = new Attack3();
    }

    public void Attack1()
    {
        attackContext.SetStrategy(attack1);
        for(int i = 0; i<=_buttons.Length-1; i++)
        {
            if(i == 0)
            {
                _buttons[i].image.color = _buttons[i].colors.selectedColor;
            } 
            else
            {
                _buttons[i].image.color = _buttons[i].colors.normalColor;
            }
        }
    }
    public void Attack2()
    {
        attackContext.SetStrategy(attack2);
        for (int i = 0; i <= _buttons.Length-1; i++)
        {
            if (i == 1)
            {
                _buttons[i].image.color = _buttons[i].colors.selectedColor;
            }
            else
            {
                _buttons[i].image.color = _buttons[i].colors.normalColor;
            }
        }
    }
    public void Attack3()
    {
        attackContext.SetStrategy(attack3);
        for (int i = 0; i <= _buttons.Length-1; i++)
        {
            if (i == 2)
            {
                _buttons[i].image.color = _buttons[i].colors.selectedColor;
            }
            else
            {
                _buttons[i].image.color = _buttons[i].colors.normalColor;
            }
        }
    }
}
