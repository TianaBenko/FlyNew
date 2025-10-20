using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.BaseAtoms
{
    [CreateAssetMenu(menuName = "Create БулУсловиеИстинности", fileName = "БулУсловиеИстинности", order = 0)]
    public class БулУсловиеИстинности : BoolCondition
    {
        [FormerlySerializedAs("сравнитьСБул")] [SerializeField] private bool долженБытьТру;
        public override bool Call(bool t)
        {
            return t == долженБытьТру;
        }
    }
}