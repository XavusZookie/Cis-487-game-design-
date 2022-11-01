using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unlockhealingpotion()
    {
        GameManager.healable = true;
    }

    public void unlockstaminameal()
    {
        GameManager.staminarecoverable = true;
    }

    public void unlockarmor()
    {
        GameManager.armor = .8f;
    }

    public void unlockfireball()
    {
        GameManager.spelllearned = true;
    }

    public void unlockthousandstrike()
    {
        GameManager.skilllearned = true;
    }

    public void unlockweapon()
    {
        GameManager.damagerange = 15;
    }
}
