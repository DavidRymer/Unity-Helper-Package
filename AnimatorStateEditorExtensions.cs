using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

public class AnimatorStateEditorExtensions
{
    private static AnimatorState state;
    
    [MenuItem("Assets/Copy Animator State")]
    private static void CopyBlendTree()
    {
        state = Selection.activeObject as AnimatorState;
        
    }
    
    [MenuItem("Assets/Paste Animator State")]
    private static void PasteBlendTree()
    {
        AnimatorState selectedBlendTree = Selection.activeObject as AnimatorState;
    
        UnityEditor.Undo.RecordObject(selectedBlendTree, "Paste Animator State");

        selectedBlendTree.motion = state.motion;
        selectedBlendTree.speed = state.speed;
        selectedBlendTree.cycleOffset = state.cycleOffset;
        selectedBlendTree.mirror = state.mirror;
        selectedBlendTree.iKOnFeet = state.iKOnFeet;
        selectedBlendTree.writeDefaultValues = state.writeDefaultValues;
        selectedBlendTree.tag = state.tag;
        selectedBlendTree.speedParameter = state.speedParameter;
        selectedBlendTree.cycleOffsetParameter = state.cycleOffsetParameter;
        selectedBlendTree.mirrorParameter = state.mirrorParameter;
        selectedBlendTree.timeParameter = state.timeParameter;
        selectedBlendTree.speedParameterActive = state.speedParameterActive;
        selectedBlendTree.cycleOffsetParameterActive = state.cycleOffsetParameterActive;
        selectedBlendTree.mirrorParameterActive = state.mirrorParameterActive;
        selectedBlendTree.timeParameterActive = state.timeParameterActive;
    }

    
    [MenuItem("Assets/Copy Animator State", true)]
    private static bool CopyAnimatorStateValidate()
    {
        return Selection.activeObject is AnimatorState;
    }
    
    [MenuItem("Assets/Paste Animator State", true)]
    private static bool PasteAnimatorStateValidate()
    {
        return state != null;
    }

}