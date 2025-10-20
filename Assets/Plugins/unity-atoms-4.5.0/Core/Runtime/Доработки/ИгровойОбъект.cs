
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Assertions;

public class ИгровойОбъект : MonoBehaviour
{
     private Dictionary<AtomEventBase, AtomEventInstancer> действия;
     private Dictionary<AtomBaseVariable, AtomBaseVariableInstancer> данные;
     
     void Awake()
     {
          действия = GetComponentsInChildren<AtomEventInstancer>().ToDictionary(
                     локальноеСобытие => локальноеСобытие.GetBase(),
                     локальноеСобытие => локальноеСобытие);
          данные = GetComponentsInChildren<AtomBaseVariableInstancer>().ToDictionary(
                     локальныеДанные => локальныеДанные.GetBase(),
                     локальныеДанные => локальныеДанные);
     }

     
     public static ИгровойОбъект Создать(ИгровойОбъект игровойОбъект)
     {
          return Instantiate(игровойОбъект);
     }

     public static Transform ПолучитьТрансформ(ИгровойОбъект игровойОбъект)
     {
          return игровойОбъект.transform;
     }
     public static ИгровойОбъект ПолучитьИговойОбъект(Collider коллайдер)
     {
          return коллайдер.GetComponent<ИгровойОбъект>();
     }
     
    
    
    

     public void ВыполнитьДействие<ТипПараметра >(AtomEventBase действие, ТипПараметра параметр)
          
     {
          //AtomEventInstancer<Vector3, Vector3Event>
          
          (действия[действие] as AtomEventInstancer<ТипПараметра>).Raise(параметр);
     }


     public void УстановитьДанные<ТипЗначения>(AtomBaseVariable ключ, ТипЗначения значение)
     {
          (данные[ключ] as AtomBaseVariableInstancer<ТипЗначения>).Value = значение;

     }

     public ТипЗначения ПолучитьДанные<ТипЗначения>(AtomBaseVariable ключ)
     {
          return (данные[ключ] as AtomBaseVariableInstancer<ТипЗначения>).Value;
     }
}