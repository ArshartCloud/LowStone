//using UnityEditor;
//using UnityEditor.UI;

//namespace Lowstone.UI
//{
//    [CustomEditor(typeof(UICard), true)]
//    [CanEditMultipleObjects]
//    public class UICardEditor : Editor
//    {
//        SerializedProperty ManaCostTextPro;


//        void OnEnable()
//        {
//            ManaCostTextPro = serializedObject.FindProperty("ManaCostText");
//        }

//        public override void OnInspectorGUI()
//        {
//            serializedObject.Update();

//            EditorGUILayout.PropertyField(ManaCostTextPro);

//            serializedObject.ApplyModifiedProperties();
//        }
//    }
//}