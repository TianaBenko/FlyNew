using System.Collections;
using System.Collections.Generic;

using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;

public class ВыпускательЛуча : MonoBehaviour
{
   
   
   [SerializeField] private LayerMask маскаСлоёв;
   [SerializeField] private UltEvent<Vector3> приСтолкновенииЛуча;
   [SerializeField] private Transform начальнаяТочка;
   private RaycastHit точкаСтолкновения;

   // out (перевод - из) это способ заставить метод наполнить переменную данными (вывести их наружу через эту переменную)
   // ref (перевод - ссылка) это способ передать в метод не значение переменной, а саму переменную (ссылку на нее)

   public void Выпустить(Ray луч, float максДистанция)
   {
      if (Physics.Raycast(луч, out точкаСтолкновения, максДистанция, маскаСлоёв))
      {
         приСтолкновенииЛуча.Invoke(точкаСтолкновения.point);
      }
   }

   // out (перевод - из) это способ заставить метод наполнить переменную данными (вывести их наружу через эту переменную)
   // ref (перевод - ссылка) это способ передать в метод не значение переменной, а саму переменную (ссылку на нее)

   public void CastRaycast(Vector3 направлениеИДлина)
   {
      if (Physics.Raycast(начальнаяТочка.position, направлениеИДлина, out RaycastHit информацияОСтолкновении,
             направлениеИДлина.magnitude, маскаСлоёв))
      {
         приСтолкновенииЛуча.Invoke(точкаСтолкновения.point);
      }
      
      
      //Physics.Raycast(transform.position, направление, out информацияОСтолкновении, направление.magnitude,маскаСлоёв);
   }
}
