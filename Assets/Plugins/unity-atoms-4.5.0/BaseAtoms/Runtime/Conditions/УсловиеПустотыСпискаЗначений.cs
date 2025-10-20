using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [CreateAssetMenu(menuName = "Create УсловиеПустотыСпискаЗначений", fileName = "УсловиеПустотыСпискаЗначений", order = 0)]
    public class УсловиеПустотыСпискаЗначений : AtomCondition
    {
        [SerializeField] private BaseAtomValueList список;
        [SerializeField] private bool долженБытьПустым;
         
        public override bool Call()
        {
             
            return (список.Count == 0) == долженБытьПустым;
        }
    }
}