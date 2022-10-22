using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Reflection;

[CustomEditor(typeof(NPCBase))]
public class NPCEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        serializedObject.Update();
        DrawPropertiesExcluding(serializedObject, GetVariables());
        serializedObject.ApplyModifiedProperties();
    }
    private string[] GetVariables()
    {
        List<string> variables = new List<string>();
        BindingFlags bindingFlags = BindingFlags.DeclaredOnly | // This flag excludes inherited variables.
                                    BindingFlags.Public |
                                    BindingFlags.NonPublic |
                                    BindingFlags.Instance |
                                    BindingFlags.Static;
        foreach (FieldInfo field in typeof(NPCBase).GetFields(bindingFlags))
        {
            variables.Add(field.Name);
        }
        return variables.ToArray();
    }
}

