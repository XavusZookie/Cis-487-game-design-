using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    NPCBase npcBase;
    [SerializeField] GameObject npc;
    private int id;
    [Header("Events")]
    public GameEvent Talking;

    private void Awake()
    {
        npcBase = npc.GetComponent<NPCBase>();
        id = -1111;
    }
    public void talkToMe(Component sender, object data)
    {
        if (data.Equals(true) && npcBase.Id == id)
        {
            Talking.Raise(inkJSON.text);
            //Debug.Log(inkJSON.text);
        }
        else
        {
            Talking.Raise(this, null);
        }
    }
    public void giveMeId(Component sender, object data)
    {
        id = (int)data;
    }
}
