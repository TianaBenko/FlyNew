using System;
using System.Collections;
using System.Collections.Generic;
using UltEvents;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ОбработчикВходаВПересечение : MonoBehaviour
{
    [SerializeField] private UltEvent<Collider> ПриВходе;
    
        
    private void OnTriggerEnter(Collider other)
    {
        if(enabled && !other.providesContacts)
        ПриВходе.Invoke(other);
        
    }
}
