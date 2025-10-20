#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Object`. Inherits from `AtomEventEditor&lt;Object, ObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ObjectEvent))]
    public sealed class ObjectEventEditor : AtomEventEditor<Object, ObjectEvent> { }
}
#endif
