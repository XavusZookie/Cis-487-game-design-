using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameEvents current;
    private void Awake()
    {
        current = this;
    }
    public event Action<int> onBuildingTriggerEnter;
    public void BuildingTriggerEnter(int id)
    {
        if(onBuildingTriggerEnter != null)
        {
            onBuildingTriggerEnter(id);
        }
    }
    public event Action<int> onBuildingTriggerExit;
    public void BuildingTriggerExit(int id)
    {
        if (onBuildingTriggerExit != null)
        {
            onBuildingTriggerExit(id);
        }
    }

}
