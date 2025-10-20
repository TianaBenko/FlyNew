#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Object`. Inherits from `AtomDrawer&lt;ObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectVariable))]
    public class ObjectVariableDrawer : VariableDrawer<ObjectVariable> { }
}
#endif
