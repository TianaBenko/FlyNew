using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;

public class ТвинерПоворота : MonoBehaviour
{


    [SerializeField] private float длительность = 0.3f;
    [SerializeField] private AnimationCurve кривая;
    [SerializeField] private Transform трансформ;


    public void Запустить(Vector3 конечныйПоворот)
    {
        трансформ.DOKill(true);
        трансформ.DORotate(конечныйПоворот, длительность).SetEase(кривая);
    }

    public void ПосмотретьНа(Transform конечныйТрансформ)
    {
        трансформ.DOKill(true);
        //трансформ.DORotate(конечныйТрансформ.rotation.eulerAngles, длительность).SetEase(кривая);
        трансформ.DOLookAt(конечныйТрансформ.position, длительность).SetEase(кривая);
    }
}