using System;
using System.Collections;
using System.Collections.Generic;
using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class ЗапускательСобытия<Тип> : ЗапускательСобытия
{
    [SerializeField] private UltEvent<Тип> событие;
    private Тип параметрДляЗадержки;

    public void Запустить(Тип параметр)
    {
        //Debug.Log($"перед запуском  {name} с параметром {параметр} ", gameObject );
        событие.Invoke(параметр);
        //Debug.Log($"после запуска  {name} с параметром {параметр} ", gameObject );
    }
    public void Запустить(float задержка, Тип параметр)
    {
        параметрДляЗадержки = параметр;
        Invoke(nameof(ЗапуститьПослеЗадержки), задержка);
    }
public void ЗапуститьПослеФиксАпдейта( Тип параметр)
    {
        параметрДляЗадержки = параметр;
        StartCoroutine(КорутинаЗапускаПослеФиксАпдейта());
        
    }


    IEnumerator КорутинаЗапускаПослеФиксАпдейта()
    {
        yield return new WaitForFixedUpdate();
        ЗапуститьПослеЗадержки();
    }

    private void ЗапуститьПослеЗадержки()
    {
        Запустить(параметрДляЗадержки);
    }
    
    private void OnDisable()
    {
        CancelInvoke();
    }

    public void ЗапуститьЕслиИстина(bool значение, Тип параметр)
    {
        if (значение)
        {
            Запустить(параметр);
        }
    }
    public void ЗапуститьЕслиЛожь(bool значение, Тип параметр)
    {
        if (!значение)
        {
            Запустить(параметр);
        }
    }
    
}

public abstract class ЗапускательСобытия : MonoBehaviour
{
    

}

