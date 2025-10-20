using UltEvents;
using UnityEngine;

public class ОбработчикФиксАпдейта : MonoBehaviour
{

    [SerializeField] private UltEvent наНовомКадре;
    
   
    void FixedUpdate()
    {
        
        наНовомКадре.Invoke();
        //Camera.main.ScreenToWorldPoint()
    }
}