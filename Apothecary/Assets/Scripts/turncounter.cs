using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class turncounter : MonoBehaviour
{

    public TMP_Text banner;
    public healthdisplay enemyhealth;
    // Start is called before the first frame update
    bool ourturn = true;
    void Start()
    {
        
        banner.text = "Your turn!";
    }



    // Update is called once per frame
    void Update()
    {
       
    }

    public void characterturn()
    {
        

        if (ourturn)
        {
            

            banner.text = "Opponents turn!";
            enemyhealth.enemyhealthcurrent -= 3;
            ourturn = false;
        }


    }

    public void opponentturn()
    {
        if (!ourturn)
        {
            

            banner.text = "Your turn!";
            GameManager.currenthealth -= 3;
            ourturn=true;
        }
        

    }

    public void slash()
    {
        if (ourturn)
        {


            banner.text = "Opponents turn!";
            enemyhealth.enemyhealthcurrent -= Random.Range(1, 3);
            ourturn = false;
        }


    }

    public void lunge()
    {
        if (ourturn)
        {


            banner.text = "Opponents turn!";
            enemyhealth.enemyhealthcurrent -= Random.Range(2, 5);
            ourturn = false;
        }


    }


}
