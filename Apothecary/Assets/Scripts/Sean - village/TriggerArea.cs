using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameEvents.current.BuildingTriggerEnter(id);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameEvents.current.BuildingTriggerExit(id);
    }
}
