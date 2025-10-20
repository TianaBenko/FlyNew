using System;
using UltEvents;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Collision`. Inherits from `UnityEvent&lt;Collision&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionUnityEvent : UltEvent<Collision> { }
}
