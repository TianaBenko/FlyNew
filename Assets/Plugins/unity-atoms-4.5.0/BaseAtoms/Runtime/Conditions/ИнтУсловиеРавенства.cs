using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.BaseAtoms
{
    [CreateAssetMenu(menuName = "Create ИнтУсловиеРавенства", fileName = "ИнтУсловиеРавенства", order = 0)]
    public class ИнтУсловиеРавенства : IntCondition
    {
        [SerializeField]  IntReference хранилищеДляСравнения;
        public override bool Call(int проверяемоеЧисло)
        {
            return проверяемоеЧисло == хранилищеДляСравнения.Value;
        }
    }
}


