using UnityEngine;

public static class Вектор
{
    public static float ПолучитьЗначениеОси(Vector3 вектор, Ось ось)
    {
        return вектор[(int)ось];
    }

        
    public enum Ось
    {
        X, Y, Z
    }
    public static Vector3 ПолучитьВектор3(Vector2 вектор2, float y)
    {
        
        return new Vector3(вектор2.x, y, вектор2.y);
    }
    public static Vector3 ПолучитьВектор3(float x, float y, float z)
    {
        
        return new Vector3(x, y, z);
    }
    
    
public static Vector2 ПолучитьXZ(Vector3 вектор3)
    {
        
        return new Vector2(вектор3.x, вектор3.z);
    }

    public static Vector3 Повернуть(Vector3 вектор, float угол)
    {
        
        Vector3 right = Vector3.Cross(Vector3.up, вектор).normalized;
        Quaternion наклон = Quaternion.AngleAxis(угол, right);


        return наклон * вектор;
    }
public static Vector3 ПовернутьВПраво(Vector3 вектор, float угол)
    {
        Vector3 right = Vector3.Cross(Vector3.right, вектор).normalized;
        Quaternion наклон = Quaternion.AngleAxis(угол, right);
        return наклон * вектор;
        
    }

    public static Quaternion ПолучитьПоворот(Vector3 вектор)
    {
        return Quaternion.LookRotation(вектор);
    }
    
}