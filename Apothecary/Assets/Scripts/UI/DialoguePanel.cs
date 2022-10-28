using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Ink.Runtime;
public class DialoguePanel : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI char_name;
    private Story currentStory;
    private bool dialogueIsPlaying;
    private TextAsset inkJSON;

    void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
    }
    //public void EnterDialogueMode(TextAsset inkJSON)
    public void EnterDialogueMode(Component sender, object data)
    {
        inkJSON = data as TextAsset;
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        ContinueStory();

    }
    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            Debug.Log("hello");
            dialogueText.text = currentStory.Continue();
        }
        else
        {
            ExitDialogueMode();
        }
    }

    public void _continue_story()
    {
        ContinueStory();
    }
}
