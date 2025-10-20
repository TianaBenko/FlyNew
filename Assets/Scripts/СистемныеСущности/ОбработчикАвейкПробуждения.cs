using System.Collections;
using System.Collections.Generic;
using UltEvents;
using UnityEngine;

public class ОбработчикАвейкПробуждения : MonoBehaviour
{
    [SerializeField] private UltEvent ПриАвейке;

    // Start is called before the first frame update
    void Awake()
    {
        ПриАвейке.Invoke();
    }
}
