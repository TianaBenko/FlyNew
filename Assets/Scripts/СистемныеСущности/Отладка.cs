using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Отладка 
{
    public static void ВывестиВКонсоль(string сообщение, Object объект)
    {
        Debug.Log($"{сообщение} {объект?.name} {Time.frameCount}");
    }
}
