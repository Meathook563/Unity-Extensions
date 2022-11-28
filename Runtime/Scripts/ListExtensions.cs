using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Extension
{
    public static class ListExtensions
    {
        public static T GetRandom<T>(this T[] list)
        {
            return list[Random.Range(0, list.Length)];
        }
    }
}


