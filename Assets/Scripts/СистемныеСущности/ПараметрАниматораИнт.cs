using UnityEngine;

[CreateAssetMenu(menuName = "Create ПараметрАниматораИнт", fileName = "ПараметрАниматораИнт", order = 0)]
public class ПараметрАниматораИнт : ПараметрАниматора<int>
{

    public override void Установить(Animator animator, int значение)
    {
        animator.SetInteger(ид, значение);
    }
}