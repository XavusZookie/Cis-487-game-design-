using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBubble : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    private void Awake()
    {
        visualCue.SetActive(false);
    }
    public void SpeechBubbleVisible(Component sender, object data)
    {
        if (data.Equals(true)) 
            visualCue.SetActive(true);
        else
            visualCue.SetActive(false);
    } 

}
