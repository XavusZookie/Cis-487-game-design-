using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    // Start is called before the first frame update
    public int id;
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    private void Awake()
    {
        visualCue.SetActive(false);
    }
    private void Start()
    {
        //
        //GameEvents.current.onNPCTriggerEnter += OnNPCInteracted;
        //
        GameEvents.current.onNPCTriggerExit += OnNPCExit;
    }
    private void OnNPCInteracted(int id)
    {
        if(id == this.id)
        {
            visualCue.SetActive(true);
            Debug.Log("you're talking with NPC" + id);
        }
    }

    private void OnNPCExit(int id)
    {
        if (id == this.id)
        {
            visualCue.SetActive(false);
            Debug.Log("you've stopped talking with NPC" + id);
        }
        // Update is called once per frame
    }

    private void OnDestroy()
    {
        GameEvents.current.onNPCTriggerEnter -= OnNPCInteracted;
        GameEvents.current.onNPCTriggerExit -= OnNPCInteracted;
    }
}
