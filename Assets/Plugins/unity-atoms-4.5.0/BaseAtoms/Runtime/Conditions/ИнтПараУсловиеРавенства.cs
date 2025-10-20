using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [CreateAssetMenu(menuName = "Create ИнтПараУсловиеРавенства", fileName = "ИнтПараУсловиеРавенства", order = 0)]
    public class ИнтПараУсловиеРавенства : AtomCondition<IntPair> 
    {
        [SerializeField]  IntReference хранилищеДляСравнения1;
        [SerializeField]  IntReference хранилищеДляСравнения2;
        
        public override bool Call(IntPair проверяемоеЧисло)
        {
            return (проверяемоеЧисло.Item1 == хранилищеДляСравнения1) && (проверяемоеЧисло.Item2 == хранилищеДляСравнения2);
        }
    }
}