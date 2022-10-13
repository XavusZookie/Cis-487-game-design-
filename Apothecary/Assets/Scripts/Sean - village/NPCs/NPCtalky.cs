using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class DataStore<T>
{
    public T Data { get; set; }
}
public class NPCtalky : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    // Update is called once per frame
    public void inRangeSet(Component sender, object data)
    {
        Debug.Log(data);
    }
    public void clickTrue(Component sender, object data)
    {
        Debug.Log(data);
    }
}
