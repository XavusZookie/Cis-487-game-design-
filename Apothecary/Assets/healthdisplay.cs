using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class healthdisplay : MonoBehaviour
{
    public TMP_Text health;
    public TMP_Text enemyhealth;

    public int enemyhealthmax = 10;
    public int enemyhealthcurrent = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health.text = GameManager.currenthealth + "/" + GameManager.maxhealth;
        enemyhealth.text = enemyhealthcurrent + "/" + enemyhealthmax;

    }
}
