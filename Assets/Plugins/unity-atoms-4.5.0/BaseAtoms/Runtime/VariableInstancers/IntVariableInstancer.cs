using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `int`. Inherits from `AtomVariableInstancer&lt;IntVariable, IntPair, int, IntEvent, IntPairEvent, IntIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Int Variable Instancer")]
    public class IntVariableInstancer : AtomVariableInstancer<
        IntVariable,
        IntPair,
        int,
        IntEvent,
        IntPairEvent,
        IntIntFunction>
    {
        public void ModifyValue(int value)
        {
            Value += value;
        }
        public void ModifyValue(bool value)
        {
            ModifyValue(value, 1);
        }
        public void ModifyValue(bool value, int число)
        {
             ModifyValue(value ?  число : -число);
        }
        
        
    }
}
