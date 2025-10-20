using DG.Tweening;
using UnityEngine;

public class ТвинерРазмера : MonoBehaviour
{
    
    [SerializeField] private float длительность = 0.3f;
    [SerializeField] private AnimationCurve кривая;
    [SerializeField] private Transform трансформ;
    [SerializeField] private Vector3 конечныйРазмер;
    
    
    public void Запустить()
    {
        трансформ.DOKill(true);
        трансформ.DOScale(конечныйРазмер, длительность).SetEase(кривая);
    }
    
}