using System.Collections.Generic;
using UnityEngine;

public static class Рандом 
{
    
    public static Vector3 ПолучитьВектор3(Vector3 мин, Vector3 макс)
    {
        //return new Vector3(Random.Range(мин.x, макс.x), Random.Range(мин.y, макс.y), Random.Range(мин.z, макс.z));
        
        for (int i = 0; i < 3; i++)
            мин[i] = Random.Range(мин[i], макс[i]);
        
        return мин;
    }
    public static Quaternion ПолучитьКватернион(Vector3 мин, Vector3 макс)
    {
        
        return  Quaternion.Euler(ПолучитьВектор3(мин, макс));
    }
    
    private static System.Random rng = new System.Random();
    public static void Shuffle<T>(this IList<T> list)
    {
         int n = list.Count;
         while (n > 1) 
         {
             n--;
             int k = rng.Next(n + 1);
             (list[k], list[n]) = (list[n], list[k]);
         }
     }

    
    
    //  (list[1], list[0]) = (list[0], list[1]); менять местами
    // private static System.Random rng = new System.Random();
    // public static void Shuffle<T>(this IList<T> list)
    // {
    //      int n = list.Count;
    //      while (n > 1) {
    //          n--;
    //          int k = rng.Next(n + 1);
    //          T value = list[k];
    //          list[k] = list[n];
    //          list[n] = value;
    //      }
    //  }
    
}
