using System.Collections.Generic;
using UnityEngine;

public class МашинаСостояний : MonoBehaviour
{
    
    [SerializeField] GameObject активноеСостояние;
    
    public void ПерейтиВСостояние(GameObject состояние)
    {
        активноеСостояние.SetActive(false);
        состояние.SetActive(true);
        активноеСостояние = состояние;
    }

    void Start()
    {
        активноеСостояние.SetActive(true);
    }
}
