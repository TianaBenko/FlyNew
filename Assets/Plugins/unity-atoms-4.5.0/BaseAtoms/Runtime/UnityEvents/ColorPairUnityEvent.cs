using System;
using UltEvents;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `ColorPair`. Inherits from `UnityEvent&lt;ColorPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorPairUnityEvent : UltEvent<ColorPair> { }
}
