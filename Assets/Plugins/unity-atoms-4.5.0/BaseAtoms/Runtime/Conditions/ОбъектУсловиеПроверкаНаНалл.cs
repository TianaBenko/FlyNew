using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Create ОбъектУсловиеЕстьНал", fileName = "ОбъектУсловиеЕстьНал", order = 0)]
    public class ОбъектУсловиеПроверкаНаНалл : ObjectCondition
    {
        [FormerlySerializedAs("равенство")] [SerializeField] private bool долженБытьНалл;
        public override bool Call(Object t)
        {
            //return долженБытьНалл ? t == null : t != null;
            return (t == null) == долженБытьНалл;
        }
    }
}