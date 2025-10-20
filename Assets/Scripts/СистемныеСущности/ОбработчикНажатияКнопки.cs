using UltEvents;
using UnityEngine;

using Button = UnityEngine.UI.Button;

public class ОбработчикНажатияКнопки : MonoBehaviour
{

    [SerializeField] private UltEvent ПриНажатии;
    [SerializeField] private UltEvent ПриОтпускании;
    
    [SerializeField] private KeyCode кнопка;
    

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(кнопка)) 
            ПриНажатии.Invoke();
        if (Input.GetKeyUp(кнопка)) 
            ПриОтпускании.Invoke();
        
        
        
    }
    
}