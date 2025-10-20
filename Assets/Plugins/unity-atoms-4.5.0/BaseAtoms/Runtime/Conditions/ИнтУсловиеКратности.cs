using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [CreateAssetMenu(menuName = "Create ИнтУсловиеКратности", fileName = "ИнтУсловиеКратности", order = 0)]
    public class ИнтУсловиеКратности : IntCondition
    {
        [SerializeField]  IntReference хранилищеДляПроверки;
        public override bool Call(int проверяемоеЧисло)
        {
            return проверяемоеЧисло%хранилищеДляПроверки.Value == 0;
        }
    }
}