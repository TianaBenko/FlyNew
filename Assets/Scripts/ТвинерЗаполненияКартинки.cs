
using DG.Tweening;
using UltEvents;
using UnityEngine;
using UnityEngine.UI;

public class ТвинерЗаполненияКартинки : MonoBehaviour
{
    [SerializeField] private float длительность = 1f;
    [SerializeField] private UltEvent приЗавершении;
    [SerializeField] private Image картинка;
    [SerializeField] private float конечноеЗначение;
    [SerializeField] private Ease кривая;
    
    

    public void Запустить()
    {
        картинка.DOFillAmount(конечноеЗначение, длительность).OnComplete(Завершить).SetEase(кривая);
        
    }

    private void Завершить()
    {
        приЗавершении.Invoke();
    }
}