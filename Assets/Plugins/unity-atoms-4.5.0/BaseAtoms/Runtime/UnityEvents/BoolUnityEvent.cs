using System;
using UltEvents;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `bool`. Inherits from `UnityEvent&lt;bool&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolUnityEvent : UltEvent<bool> { }
}
