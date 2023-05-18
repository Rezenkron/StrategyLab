using UnityEngine;
using UnityEngine.UI;

public class AttackPerformer : MonoBehaviour
{
    [SerializeField] private Animator _anim;

    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;

    Player player;

    private Attack1 attack1;
    private Attack2 attack2;
    private Attack3 attack3;

    private void OnEnable()
    {
        button1.onClick.AddListener(() => Attack(attack1, button1));
        button2.onClick.AddListener(() => Attack(attack2, button2));
        button3.onClick.AddListener(() => Attack(attack3, button3));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.PerformAttack();
        }
    }

    private void Awake()
    {
        player = new Player(_anim);
        attack1 = new Attack1();
        attack2 = new Attack2();
        attack3 = new Attack3();
    }
    
    private void Attack(IAttackStrategy strategy, Button button)
    {
        player.SetStrategy(strategy);
        ChangeButtonColor(button);
    }

    private void ChangeButtonColor(Button button)
    {
        Button[] buttons = new Button[] { button1, button2, button3 };
        for(int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i] == button)
            {
                buttons[i].image.color = Color.yellow;
            }
            else if (buttons[i] != button)
            {
                buttons[i].image.color = Color.white;
            }
        }
    }
    private void OnDisable()
    {
        button1.onClick.RemoveAllListeners();
        button2.onClick.RemoveAllListeners();
        button3.onClick.RemoveAllListeners();
    }
}
