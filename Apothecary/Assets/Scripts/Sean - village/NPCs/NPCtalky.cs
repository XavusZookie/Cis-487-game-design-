using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtalky : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    // Update is called once per frame
    public bool poop;
    private void Awake()
    {
        poop = false;
    }
    public void talkToMe(Component sender, object data)
    {
        if (data.Equals(true) && poop==true)
        {
            Debug.Log("Great success! Your NPC should be able to talk to you now");
        }
    }
    public void inRangeSet(Component sender, object data)
    {
        if (data.Equals(true))
            poop = true;
        else
            poop = false;

    }
    public void clickTrue(Component sender, object data)
    {
        Debug.Log(data);
    }
}
