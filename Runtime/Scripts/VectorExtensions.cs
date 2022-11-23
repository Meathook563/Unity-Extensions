using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JustSomeExtenions
{
    public static class VectorExtensions
    {
        public static Vector2 GetCloseVectorFrom(this Vector2 vector, Vector2[] otherVectors)
        {
            if(otherVectors.Length == 0) 
            {
                throw new System.Exception("The list of other vectors is Empty");
            }
            float minDistance = Vector2.Distance(vector, otherVectors[0]);
            Vector2 minVector = otherVectors[0];

            for(int i = otherVectors.Length - 1; i > 0; i++)
            {
                float newDistance = Vector2.Distance(vector, otherVectors[i]);
                if(newDistance < minDistance)
                {
                    minDistance = newDistance;
                    minVector = otherVectors[i];
                }
            }

            return minVector;
        }
        
        public static Vector3 GetCloseVectorFrom(this Vector3 vector, Vector3[] otherVectors)
        {
            if(otherVectors.Length == 0) 
            {
                throw new System.Exception("The list of other vectors is Empty");
            }
            float minDistance = Vector3.Distance(vector, otherVectors[0]);
            Vector3 minVector = otherVectors[0];

            for(int i = otherVectors.Length - 1; i > 0; i++)
            {
                float newDistance = Vector3.Distance(vector, otherVectors[i]);
                if(newDistance < minDistance)
                {
                    minDistance = newDistance;
                    minVector = otherVectors[i];
                }
            }

            return minVector;
        }
    }
}


