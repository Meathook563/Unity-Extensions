using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JustSomeExtenions
{
    public static class GameObjectExtensions
    {
        public static  bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() != null;
        }
    }
}


