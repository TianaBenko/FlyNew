using UltEvents;
using UnityEngine;

public class ОбработчикВыключения : MonoBehaviour
{
    [SerializeField] private UltEvent приВыключении;
    
    private void OnDisable()
    {
        приВыключении.Invoke();
    }
}