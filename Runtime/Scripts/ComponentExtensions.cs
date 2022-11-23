﻿using UnityEngine;

namespace JustSomeExtenions
{
    public static class ComponentExtensions
    {
        public static bool HasComponent<T>(this Component component) where T : Component
        {
            return component.GetComponent<T>() != null;
        }
    }
}


