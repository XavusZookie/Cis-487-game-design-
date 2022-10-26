using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTriggerArea : MonoBehaviour
{
    // Start is called before the first frame update
    public GameEvent onNPCinRange;
    NPCBase npcBase;
    [SerializeField] GameObject npc;

    private void Awake()
    {
        npcBase = npc.GetComponent<NPCBase>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            //GameEvents.current.NPCTriggerEnter(id);        
            onNPCinRange.Raise(npcBase.Id);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            //GameEvents.current.NPCTriggerExit(id);
            onNPCinRange.Raise(-99);
    }
}
