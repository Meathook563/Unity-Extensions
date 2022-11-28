using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JustSomeExtenions
{
    public static class RandomExtensions
    {
        public static Vector2 RandomVector2()
        {
            return new Vector2(Random.Range(0, 100),
                               Random.Range(0, 100));
        }   

        public static Vector2 RandomVector2(float range)
        {
            return new Vector2(Random.Range(-range, range),
                               Random.Range(-range, range));
        }

        public static Vector2 RandomVector2(Vector2 min, Vector2 max)
        {
            return new Vector2(Random.Range(min.x, max.x),
                               Random.Range(min.y, max.y));
        }

        public static Vector3 RandomVector3()
        {
            return new Vector3(Random.Range(0, 100),
                               Random.Range(0, 100),
                               Random.Range(0, 100));
        }

        public static Vector3 RandomVector3(float range)
        {
            return new Vector3(Random.Range(0, range),
                               Random.Range(0, range),
                               Random.Range(0, range));
        }

        public static Vector3 RandomVector3(Vector3 min, Vector3 max)
        {
            return new Vector3(Random.Range(min.x, max.x),
                               Random.Range(min.y, max.y),
                               Random.Range(min.z, max.z));
        }                         
    }
}
