using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace JustSomeExtenions
{
    [System.AttributeUsage(System.AttributeTargets.Field)]
    public class InspectorButtonAttribute : PropertyAttribute
    {
        public static float DefualtButtonWidth = 300;
        public readonly string MethodName;
        
        private float _buttonWidth = DefualtButtonWidth;
        public float ButtonWidth
        {
            get { return _buttonWidth; }
            set { _buttonWidth = value; }
        }

        public InspectorButtonAttribute(string methodName)
        {
            MethodName = methodName;
        }
    }

    #if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(InspectorButtonAttribute))]
    public class InspectorButtonPropertyDrawer : PropertyDrawer
    {
        private MethodInfo _methodInfo = null;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            InspectorButtonAttribute buttonAttribute = (InspectorButtonAttribute)attribute;
            Rect buttonRect = new Rect(position.x + (position.width * 0.2f - buttonAttribute.ButtonWidth) * 0f, position.y, buttonAttribute.ButtonWidth, position.height);
            if(GUI.Button(buttonRect, label.text))
            {
                System.Type eventOwner = property.serializedObject.targetObject.GetType();
                string eventName = buttonAttribute.MethodName;

                if(_methodInfo == null)
                    _methodInfo = eventOwner.GetMethod(eventName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                
                if(_methodInfo != null)
                    _methodInfo.Invoke(property.serializedObject.targetObject, null);
                else
                    Debug.LogWarning(string.Format("Inspector Button: Unable to find method {0} in {1}", eventName, eventOwner));
            }
        }
    }
}
#endif
