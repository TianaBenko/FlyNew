using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Object`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ObjectVariable))]
    public sealed class ObjectVariableEditor : AtomVariableEditor<Object, ObjectPair> { }
}
