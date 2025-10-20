using System;
using UltEvents;
using UnityEngine;

public class ПлавныйМодификаторФлоат : MonoBehaviour
{
    [SerializeField] private Vector2 границыРасстояния;
    [SerializeField] private Vector2 границыСкорости;
    [SerializeField] private float текущееЗначение;
    [SerializeField] private UltEvent<float> ПриСменеТекущегоЗначения;
    private float _целевоеЗначение;
    
    public void Иницилизировать(float целевоеЗначение)
    {
        _целевоеЗначение = целевоеЗначение;
        gameObject.SetActive(true);
    }
    
    private void LateUpdate()
    {
        
        РассчитатьТекущееЗначение();
        ПриСменеТекущегоЗначения.Invoke(текущееЗначение);
        
        if(текущееЗначение == _целевоеЗначение)
            gameObject.SetActive(false);
    }

    public void РассчитатьТекущееЗначение()
    {
        float расстояние = Mathf.Abs(текущееЗначение - _целевоеЗначение);
        float скорость = Математика.Map(границыРасстояния.x, границыРасстояния.y, 
            границыСкорости.x, границыСкорости.y, расстояние);
        скорость *=   Time.deltaTime;
        текущееЗначение = Mathf.MoveTowards(текущееЗначение, _целевоеЗначение, скорость);
        
        
    }
}