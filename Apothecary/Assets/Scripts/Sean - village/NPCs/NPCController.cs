using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    // Start is called before the first frame update
    public int id;
    public GameEvent onNPCinRange;
    private void Start()
    {
        GameEvents.current.onNPCTriggerEnter += OnNPCInteracted;
        GameEvents.current.onNPCTriggerExit += OnNPCExit;
    }
    private void OnNPCInteracted(int id)
    {
        if(id == this.id)
        {
            //visualCue.SetActive(true);
            onNPCinRange.Raise(this, true);
            //Debug.Log("you're talking with NPC" + id);
        }
    }

    private void OnNPCExit(int id)
    {
        if (id == this.id)
        {
            onNPCinRange.Raise(this, false);
            //Debug.Log("you've stopped talking with NPC" + id);
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onNPCTriggerEnter -= OnNPCInteracted;
        GameEvents.current.onNPCTriggerExit -= OnNPCInteracted;
    }
}
