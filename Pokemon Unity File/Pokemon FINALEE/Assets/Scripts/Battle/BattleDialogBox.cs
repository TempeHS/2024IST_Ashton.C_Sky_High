using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogBox : MonoBehaviour
{
    [SerializeField] int lettersPerSecond;
    [SerializeField] Color highlightedColor;
    [SerializeField] Text dialogText;
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveSelector;
    [SerializeField] GameObject moveDetails;

    [SerializeField] List<Text> actionTexts;
    [SerializeField] List<Text> moveTexts;

    [SerializeField] Text ppText;
    [SerializeField] Text typeText;



    /// <summary>
    /// Displays the dialog instantly (without typing effect).
    /// </summary>
    public void SetDialog(string dialog)
    {
        dialogText.text = dialog;
    }

    /// <summary>
    /// Types the dialog text one character at a time.
    /// </summary>
    public IEnumerator TypeDialog(string dialog)
    {
        dialogText.text = "";
        foreach (char letter in dialog.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));  // Wait for space key press to continue
    }

    /// <summary>
    /// Enable or disable the dialog text.
    /// </summary>
    public void EnableDialogText(bool enabled)
    {
        dialogText.enabled = enabled;
    }

    /// <summary>
    /// Enable or disable the action selector UI.
    /// </summary>
    public void EnableActionSelector(bool enabled)
    {
        actionSelector.SetActive(enabled);
    }

    /// <summary>
    /// Enable or disable the move selector UI.
    /// </summary>
    public void EnableMoveSelector(bool enabled)
    {
        moveSelector.SetActive(enabled);
        moveDetails.SetActive(enabled);
    }

    /// <summary>
    /// Updates the action menu text (Fight, Run, etc.).
    /// </summary>
    public void UpdateActionSelection(int selectedAction)
    {
        for (int i = 0; i < actionTexts.Count; i++)
        {
            if (i == selectedAction)
                actionTexts[i].color = Color.yellow;  // Highlight selected action
            else
                actionTexts[i].color = Color.white;
        }
    }

    /// <summary>
    /// Updates the move menu with move names and details (PP, type).
    /// </summary>
    public void UpdateMoveSelection(int selectedMove, Move move)
    {
        for (int i = 0; i < moveTexts.Count; i++)
        {
            if (i == selectedMove)
                moveTexts[i].color = Color.yellow;  // Highlight selected move
            else
                moveTexts[i].color = Color.white;
        }

        ppText.text = $"PP: {move.PP}/{move.Base.PP}";
        typeText.text = move.Base.Type.ToString();
    }

    // Public getter to expose actionTexts count for BattleSystem.cs
    public int GetActionTextCount()
    {
        return actionTexts.Count;
    }

    public void UpdateActionSelection()
    {
        for (int i=0; i < actionTexts.Count; ++i)
        {
            if (i == selectedAcion);
        }
    }
}
