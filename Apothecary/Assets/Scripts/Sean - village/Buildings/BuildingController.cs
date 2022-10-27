using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour
{
    // Start is called before the first frame update
    public int id;
    public bool blacksmith = false;
    public GameObject blacksmithUI;

    private void Start()
    {
        GameEvents.current.onBuildingTriggerEnter += OnBuildingInteracted;
        GameEvents.current.onBuildingTriggerExit += OnBuildingExit;
    }

    // Update is called once per frame
    private void OnBuildingInteracted(int id)
    {
        if(id == this.id)
        {
            Debug.Log("you're interacting with building #" + id);
        }

        if (this.id == 2 && this.id == id && blacksmith==false)
        {
            Time.timeScale = 0;

            blacksmithUI.SetActive(true);
            
        }

        if (this.id == 3 && this.id == id)
        {
          
            if (GameManager.blueherb == 1)
            {
                GameManager.blueherb--;
                GameManager.currenthealth+= 10;
                GameManager.maxhealth += 10;
                

            }

        }

    }
    private void OnBuildingExit(int id)
    {
        if(id == this.id)
        {
            Debug.Log("you're exiting building #" + id);
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onBuildingTriggerEnter -= OnBuildingInteracted;
        GameEvents.current.onBuildingTriggerExit -= OnBuildingExit;
    }
}
