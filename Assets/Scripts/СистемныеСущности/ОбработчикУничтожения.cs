using UltEvents;
using UnityEngine;

public class ОбработчикУничтожения : MonoBehaviour
{
    [SerializeField] private UltEvent ПриУничтожении;

    // Start is called before the first frame update
    void OnDestroy()
    {
        ПриУничтожении.Invoke();
    }
    
}