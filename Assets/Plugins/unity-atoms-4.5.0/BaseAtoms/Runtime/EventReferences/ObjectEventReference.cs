using System;
using UnityEngine;
using Object = UnityEngine.Object;
namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Object`. Inherits from `AtomEventReference&lt;Object, ObjectVariable, ObjectEvent, ObjectVariableInstancer, ObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectEventReference : AtomEventReference<
        Object,
        ObjectVariable,
        ObjectEvent,
        ObjectVariableInstancer,
        ObjectEventInstancer>, IGetEvent 
    { }
}
