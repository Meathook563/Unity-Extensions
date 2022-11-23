using System;
using UnityEngine;

namespace JustSomeExtenions
{
    public static class TransformExtensions
    {
        public static void ResetTransformation(this Transform transform)
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public static void DestroyChildren(this Transform transform)
        {
            for (int i = transform.childCount - 1; i >= 0; i--)
            {
                UnityEngine.Object.Destroy(transform.GetChild(i).gameObject);
            }
        }

        public static void SetChildLayers(this Transform transform, string layerName, bool recursive = false)
        {
            int layer = LayerMask.NameToLayer(layerName);
            SetChildLayersHelper(transform, layer, recursive);
        }

        private static void SetChildLayersHelper(Transform transform, int layer, bool recursive)
        {
            foreach(Transform child in transform)
            {
                child.gameObject.layer = layer;

                if(recursive)
                {
                    SetChildLayersHelper(child, layer, recursive);
                }
            }
        }

        public static void SetX(this Transform transform, float x)
        {
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
        public static void SetY(this Transform transform, float y)
        {
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
        public static void SetZ(this Transform transform, float z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
        }
    }
}


