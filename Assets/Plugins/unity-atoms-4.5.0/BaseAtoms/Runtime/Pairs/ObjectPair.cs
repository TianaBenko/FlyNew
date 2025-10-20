using System;
using UnityEngine;
using Object = UnityEngine.Object;
namespace UnityAtoms

{
    /// <summary>
    /// IPair of type `&lt;Object&gt;`. Inherits from `IPair&lt;Object&gt;`.
    /// </summary>
    [Serializable]
    public struct ObjectPair : IPair<Object>
    {
        public Object Item1 { get => _item1; set => _item1 = value; }
        public Object Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Object _item1;
        [SerializeField]
        private Object _item2;

        public void Deconstruct(out Object item1, out Object item2) { item1 = Item1; item2 = Item2; }
    }
}