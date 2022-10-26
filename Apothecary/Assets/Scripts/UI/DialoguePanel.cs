using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class DialoguePanel : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private Animator animator;
    [SerializeField] private TextMeshProUGUI dialogueText;  //gonna make this do that slow typin fx
    
    private Story currentStory;
    private bool dialogueIsPlaying;
    //private string currentAnimation;
    //Animation States
    //const string BUBBLE_PLAY = "bubble_play";
    //const string BUBBLE_PAUSE = "bubble_pause";
    // Start is called before the first frame update

    private void Awake()
    {
        dialogueText.GetComponent<DialoguePanel>();
        dialoguePanel.SetActive(false);
    }
    void Start()
    {
        dialogueIsPlaying = false;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }


    }

    public void DialogueBoxVisible(Component sender, object data)
    {
        //Debug.Log("this triggered");
        //if ((string)data != null) {
            //Debug.Log("if_statement_true");
            //dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text = ((string)data);
        currentStory = new Story((string)data);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        ContinueStory();
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();//popping the next line of dialogue onto the stack
        }
        else
        {
            ExitDialogueMode();
        }
    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    // Update is called once per frame
}
