using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Void`. Inherits from `AtomEvent&lt;Void&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Void", fileName = "VoidEvent")]
    public sealed class VoidEvent : AtomEvent<Void>
    {
        public static void Выполнить(Object игровойОбъект, Object воидИвент)
        {
            (воидИвент as VoidEvent).Выполнить(игровойОбъект, new Void());
        }
        public void Выполнить(Object игровойОбъект)
        {
            Выполнить(игровойОбъект, new Void());
        }
        public override void Raise()
        {
            Raise(new Void());
        }
    }
}
