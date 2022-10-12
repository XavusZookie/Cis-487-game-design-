using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTriggerArea : MonoBehaviour
{
    // Start is called before the first frame update
    public int id;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            GameEvents.current.NPCTriggerEnter(id);        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            GameEvents.current.NPCTriggerExit(id);
    }
}
