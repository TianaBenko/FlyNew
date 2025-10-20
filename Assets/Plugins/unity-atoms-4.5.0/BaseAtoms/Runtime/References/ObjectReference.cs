using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using Object = UnityEngine.Object;


namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Object`. Inherits from `AtomReference&lt;Object, ObjectPair, ObjectConstant, ObjectVariable, ObjectEvent, ObjectPairEvent, ObjectObjectFunction, ObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectReference : AtomReference<
        Object,
        ObjectPair,
        ObjectConstant,
        ObjectVariable,
        ObjectEvent,
        ObjectPairEvent,
        ObjectObjectFunction,
        ObjectVariableInstancer>, IEquatable<ObjectReference>
    {
        public ObjectReference() : base() { }
        public ObjectReference(Object value) : base(value) { }
        public bool Equals(ObjectReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Object other)
        {
            throw new NotImplementedException();
        }
    }
}
