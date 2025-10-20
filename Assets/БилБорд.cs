using System;
using UnityEngine;

public class БилБорд : MonoBehaviour
{
    private Transform камера;

    private void Start()
    {
        камера = Camera.main.transform;
    }

    void LateUpdate()
    {
        transform.rotation = камера.rotation;
    }
}
