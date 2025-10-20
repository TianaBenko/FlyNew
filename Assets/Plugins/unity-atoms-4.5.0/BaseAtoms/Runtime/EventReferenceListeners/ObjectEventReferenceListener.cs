using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Object`. Inherits from `AtomEventReferenceListener&lt;Object, ObjectEvent, ObjectEventReference, ObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Object Event Reference Listener")]
    public sealed class ObjectEventReferenceListener : AtomEventReferenceListener<
        Object,
        ObjectEvent,
        ObjectEventReference,
        ObjectUnityEvent>
    { }
}
