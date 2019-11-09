﻿using UnityEngine;
using UnityEditor;

namespace Toolbox.Editor.Drawers
{
    public class BeginHorizontalAttributeDrawer : ToolboxDecoratorDrawer<BeginHorizontalAttribute>
    {
        public override void OnGuiBegin(BeginHorizontalAttribute attribute)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = attribute.LabelWdith;
        }
    }
}