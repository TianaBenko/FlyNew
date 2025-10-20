using System.Collections;
using System.Collections.Generic;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ОбработчикСтарта : MonoBehaviour
{
    [SerializeField] private UltEvent ПриСтарте;

    // Start is called before the first frame update
    void Start()
    {
        ПриСтарте.Invoke();
    }
    
}