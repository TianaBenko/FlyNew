using System;
using System.Collections;
using System.Collections.Generic;
using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;

public class ЗапускательСобытияБезПараметра : ЗапускательСобытия<Ничто>
{
   public void Запустить()
   {
      Запустить(new Ничто());
   }

   public void Запустить(float задержка)
   {
      Запустить(задержка, new Ничто());
   }

   public void ЗапуститьПослеФиксАпдейта()
   {
      ЗапуститьПослеФиксАпдейта(new Ничто());
   }
   
   public void ЗапуститьЕслиИстина(bool значение)
   {
      if (значение)
      {
         Запустить();
      }
   }

   public void ЗапуститьЕслиЛожь(bool значение)
   {
      if (!значение)
      {
         Запустить();
      }
   }
   public void ЗапуститьЕслиЛожь(bool значение, float задержка)
   {
      if (!значение)
      {
         Запустить(задержка);
      }
   }
   public void ЗапуститьЕслиИстина(bool значение, float задержка)
   {
      if (значение)
      {
         Запустить(задержка);
      }
   }
   
}

public struct Ничто
{
    
}


