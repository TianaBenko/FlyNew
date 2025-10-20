using System;
using System.Collections;
using System.Collections.Generic;
using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;

public class ОбработчикНаведенияМыши : MonoBehaviour
{
    [SerializeField] private UltEvent приНаведенииМыши;
    [SerializeField] private UltEvent приУбиранииМыши;
    public bool активен = true;
    private void OnMouseEnter()
    {
        if (активен)
        {
            приНаведенииМыши.Invoke();
        }
        
    }

    private void OnMouseExit()
    {
        if (активен)
        {
            приУбиранииМыши.Invoke();
        }
        
    }
}
