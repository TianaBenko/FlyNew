using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Математика 
{
    
    
    public static float Разделить (int делимое, float делитель)
    {
        return делимое / делитель;

    }
    public static Vector3 Умножить (Vector3 множитель1 ,int множитель2 )
    {
        return множитель1 * множитель2;

    }

    public static bool Инвертировать(bool значение)
    {
        return !значение;
    }

    public static float Map(float начМин, float начМакс, float конечМин, float конечМакс, float значение)
    {
        float нормализованное = Mathf.InverseLerp(начМин, начМакс, значение);
        Mathf.Clamp01(нормализованное);
        return Mathf.Lerp(конечМин, конечМакс, Mathf.Clamp01(нормализованное));

    }
}
