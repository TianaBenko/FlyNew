using System;
using System.Collections;
using System.Collections.Generic;
using UltEvents;
using UnityEngine;

public class ОбработчикКликаПоОбъекту : MonoBehaviour
{
    [SerializeField] private UltEvent приНажатииМыши;
    public bool активен = true;
    private void OnMouseUpAsButton()
    {
        if (активен)
        {
            приНажатииМыши.Invoke();
        }
        
    }
}
