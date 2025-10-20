using System;
using UnityEditor;
using UnityEngine;

public abstract class ПараметрАниматора : ScriptableObject
{
    [SerializeField] protected int ид;

#if UNITY_EDITOR 
        private  void Reset()
        {
                ид = Animator.StringToHash(
                    System.IO.Path.GetFileNameWithoutExtension(
                        AssetDatabase.GetAssetPath(this)));
                
        }
#endif

}


public abstract class ПараметрАниматора<Тип> : ПараметрАниматора
{
    public abstract void Установить(Animator animator, Тип значение);

}