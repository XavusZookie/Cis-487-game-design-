using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bsui : MonoBehaviour
{
    public BuildingController bc;

    public GameObject blacksmithUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void curebs()
    {
        if (GameManager.redherb >1)
        {
            bc.blacksmith = true;
            GameManager.redherb -= 2;
            GameManager.damagerange += 5;
        }
        Time.timeScale = 1;
        blacksmithUI.SetActive(false);
    }

    public void notnow()
    {
        Time.timeScale = 1;

        blacksmithUI.SetActive(false);
    }
}
