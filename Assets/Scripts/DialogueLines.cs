using TMPro;
using UnityEngine;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] string[] timelineTextLines;
    [SerializeField] TMP_Text dialogueText;

    int currentLine = 0;

    public void NextDialogue()
    {
        dialogueText.text = timelineTextLines[currentLine];
        currentLine++;
    }
}
