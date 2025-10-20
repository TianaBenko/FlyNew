using System;
using UltEvents;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `IntPair`. Inherits from `UnityEvent&lt;IntPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntPairUnityEvent : UltEvent<IntPair> { }
}
