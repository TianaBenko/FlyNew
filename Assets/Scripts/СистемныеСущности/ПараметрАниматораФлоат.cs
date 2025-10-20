using UnityEngine;

[CreateAssetMenu(menuName = "Create ПараметрАниматораФлоат", fileName = "ПараметрАниматораФлоат", order = 0)]
public class ПараметрАниматораФлоат : ПараметрАниматора<float>
{

    public override void Установить(Animator animator, float значение)
    {
        animator.SetFloat(ид, значение);
    }
    public void УстановитьСлучайное(Animator animator, int максимальноеЗначение)
    {
        Установить(animator, Random.Range(0, максимальноеЗначение + 1));
    }
    
    
}