using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Object`. Inherits from `AtomVariableInstancer&lt;ObjectVariable, ObjectPair, Object, ObjectEvent, ObjectPairEvent, ObjectObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Object Variable Instancer")]
    public class ObjectVariableInstancer : AtomVariableInstancer<
        ObjectVariable,
        ObjectPair,
        Object,
        ObjectEvent,
        ObjectPairEvent,
        ObjectObjectFunction>
    { }
}
