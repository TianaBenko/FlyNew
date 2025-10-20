using UltEvents;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class КнопкаИнтерфейса : Selectable
{
    [SerializeField] private UltEvent ПриНажатии;
    [SerializeField] private UltEvent ПриОтрускании;
    
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left)
                 return;
        
        base.OnPointerDown(eventData);
        
        if (IsInteractable())
            ПриНажатии.Invoke();
    }

    public override void OnPointerUp(PointerEventData eventData)
    { 
        if (eventData.button != PointerEventData.InputButton.Left)
            return;
        base.OnPointerUp(eventData); 
       
        ПриОтрускании.Invoke();
    }
}