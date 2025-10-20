using UnityEngine;

[CreateAssetMenu(menuName = "Create ПараметрАниматораБул", fileName = "ПараметрАниматораБул", order = 0)]
public class ПараметрАниматораБул : ПараметрАниматора<bool>
{
    

    public override void Установить(Animator animator, bool значение)
    {
        animator.SetBool(ид, значение);
    }
}