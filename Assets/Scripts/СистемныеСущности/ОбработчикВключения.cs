using System;
using UltEvents;
using Unity.VisualScripting;
using UnityEngine;

public class ОбработчикВключения : MonoBehaviour
{
    [SerializeField] private UltEvent приВключении;
    
    private void OnEnable()
    {
        приВключении.Invoke();
    }
}