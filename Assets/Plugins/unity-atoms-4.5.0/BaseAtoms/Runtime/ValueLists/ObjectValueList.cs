using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Object`. Inherits from `AtomValueList&lt;Object, ObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Object", fileName = "ObjectValueList")]
    public sealed class ObjectValueList : AtomValueList<Object, ObjectEvent>
    {
        public Transform ПолучитьБлижайшийТрансформ(Transform трансформ)
        {
            float минимальнаяДистанция = float.MaxValue;
            Transform ближайшийТрансформ = трансформ;
            

            foreach (var элемент in list)
            {
                var дистанция = ((элемент as Transform).position - трансформ.position).sqrMagnitude;
                if (дистанция < минимальнаяДистанция)
                {
                    минимальнаяДистанция = дистанция;
                    ближайшийТрансформ = (элемент as Transform);
                }
            }
            return ближайшийТрансформ;

        }
    }
}
