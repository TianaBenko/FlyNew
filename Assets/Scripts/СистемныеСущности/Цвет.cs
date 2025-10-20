using UnityEngine;

public static class Цвет
{
    public static Color ПолучитьЦвет(float r, float g, float b, float a)
    {
        
        return new Color(r, g, b, a);
    }

    public static Material УстановитьЦвет(Material материал, Color цвет)
    {
        материал.color = цвет;
        return материал;
    }
}