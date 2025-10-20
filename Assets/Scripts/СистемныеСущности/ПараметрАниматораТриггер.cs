using UnityEngine;

[CreateAssetMenu(menuName = "Create ПараметрАниматораТриггер", fileName = "ПараметрАниматораТриггер", order = 0)]
public class ПараметрАниматораТриггер : ПараметрАниматора
{

    public void Установить(Animator animator)
    {
        animator.SetTrigger(ид);
    }
}