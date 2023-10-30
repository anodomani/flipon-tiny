using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "DialogueManagerData", menuName = "Dialogue System/Dialogue Manager Data")]
public class DialogueDataManager : ScriptableObject
{   
    public List<SingleDialogueData> allDialogues = new List<SingleDialogueData>();
    public List<SingleDialogueData> shownDialogues = new List<SingleDialogueData>();

    public void MarkDialogueAsShown(SingleDialogueData dialogue)
    {
        if (!IsDialogueAlreadyShown(dialogue))
        {
            allDialogues.Add(dialogue);
            EditorUtility.SetDirty(this); // Mark the scriptable object as dirty.
		}
		else
		{
            shownDialogues.Add(dialogue);
        }
    }


    public bool IsDialogueAlreadyShown(SingleDialogueData dialogue)
    {
        return shownDialogues.Contains(dialogue);
    }

    public void ResetShownDialogues()
    {
        shownDialogues.Clear();
        allDialogues.Clear();
        EditorUtility.SetDirty(this); // Mark the scriptable object as dirty.
    }
}
