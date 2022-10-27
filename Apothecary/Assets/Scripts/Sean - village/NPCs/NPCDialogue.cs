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
    private void Awake()
    {
        npcBase = npc.GetComponent<NPCBase>();
        id = -1111;
    }
    public void talkToMe(Component sender, object data)
    {
        if (data.Equals(true) && npcBase.Id == this.id)
        {
            Debug.Log(inkJSON.text);
        }
    }
    public void giveMeId(Component sender, object data)
    {
        id = (int)data;
    }

}
