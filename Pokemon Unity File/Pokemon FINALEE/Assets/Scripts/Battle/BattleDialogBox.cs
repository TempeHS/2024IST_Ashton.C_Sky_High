using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogBox : MonoBehaviour
{
    [SerializeField] private Text dialogText;
    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private GameObject actionSelector;
    [SerializeField] private GameObject moveSelector;
    [SerializeField] private GameObject moveDetails;
    [SerializeField] private List<Text> actionTexts;
    [SerializeField] private List<Text> moveTexts;
    [SerializeField] private Text ppText;
    [SerializeField] private Text typeText;

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
    /// Toggles visibility of the action selector UI.
    /// </summary>
    public void EnableActionSelector(bool enabled)
    {
        actionSelector.SetActive(enabled);
    }

    /// <summary>
    /// Toggles visibility of the move selector UI.
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

    /// <summary>
    /// Enables or disables the dialog text box.
    /// </summary>
    public void EnableDialogText(bool enabled)
    {
        dialogText.enabled = enabled;
    }
}
