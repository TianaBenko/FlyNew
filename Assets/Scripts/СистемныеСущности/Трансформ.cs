

    using System;
    using UnityEngine;

    public static class Трансформ
    {
        public static void УстановитьРодителя(Transform ребенок, Transform родитель, bool мироваяПозицияОстается)
        {
            ребенок.SetParent(родитель, мироваяПозицияОстается);
        }

         public static void Повернуть(Transform трансформ, Vector3 значениеПоворота)
        {
            трансформ.Rotate(значениеПоворота);
        }
         public static void УстановитьПозицию(Transform трансформ, Vector3 позиция)
        {
            трансформ.position = позиция;
        }

        public static Vector3 ПолучитьПозицию(Transform трансформ)
        {
            return трансформ.position;
        }

        public static void УстановитьПоворот(Transform трансформ, Quaternion поворот)
        {
            трансформ.rotation = поворот;

        }

        
    }