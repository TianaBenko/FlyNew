using UltEvents;
using UnityEngine;

public class ОбработчикНовогоКадра : MonoBehaviour
{

    [SerializeField] private UltEvent<float> наНовомКадре;
    
   
    void Update()
    {
        
        наНовомКадре.Invoke(Time.deltaTime);
        //Camera.main.ScreenToWorldPoint()
    }
}