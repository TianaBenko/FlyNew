using System;
using UnityEngine;
using Object = UnityEngine.Object;




namespace UnityAtoms
{
    public abstract class ObjectVariable<T> : ObjectVariable
        where T : Object
    {
        public T ПолучитьСТипом (ИгровойОбъект игровойОбъект)
        {
            return Получить(игровойОбъект) as T;
        }

        public static T КонвертироватьВТип(Object объект)
        {
            return объект as T;
        }
    }
    /// <summary>
    /// Variable of type `Object`. Inherits from `AtomVariable&lt;Object, ObjectPair, ObjectEvent, ObjectPairEvent, ObjectObjectFunction&gt;`.
    /// </summary>
    
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Object", fileName = "ObjectVariable")]
    public  class ObjectVariable : AtomVariable<Object, ObjectPair, ObjectEvent, ObjectPairEvent, ObjectObjectFunction>
    {
        protected override bool ValueEquals(Object other)
        {
            return Value == other;
        }

        public Transform ValueTransform => (Value as ИгровойОбъект).transform;

        

        
        
    }
}
