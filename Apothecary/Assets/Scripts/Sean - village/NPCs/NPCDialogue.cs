using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    //NPCBase npcBase;
    //[SerializeField] GameObject npc;
    private bool check;
    private void Awake()
    {
        check = false;
        //npcBase = npc.GetComponent<NPCBase>();
    }
    public void talkToMe(Component sender, object data)
    {
        if (data.Equals(true) && check==true)
        {
            Debug.Log("Great success! Your NPC should be able to talk to you now");
        }
    }
    public void inRangeSet(Component sender, object data)
    {
        if (data.Equals(true))
            check = true;
        else
            check = false;

    }
}
