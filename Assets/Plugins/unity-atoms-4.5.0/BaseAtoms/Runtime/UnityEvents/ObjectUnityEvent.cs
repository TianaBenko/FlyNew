
using System;
using UltEvents;
using Object = UnityEngine.Object;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Object`. Inherits from `UnityEvent&lt;Object&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectUnityEvent : UltEvent<Object> { }
}
