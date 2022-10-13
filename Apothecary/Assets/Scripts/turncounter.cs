using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class turncounter : MonoBehaviour
{

    public TMP_Text banner;
    public healthdisplay enemyhealth;
    // Start is called before the first frame update
    bool ourturn = true;
    bool battlefinished = false;
    int reward;
    void Start()
    {
        Random.seed = System.DateTime.Now.Millisecond;
        banner.text = "Your turn!";
    }



    // Update is called once per frame
    void Update()
    {
   
    }

    public void enemydefeated()
    {
        if (enemyhealth.enemyhealthcurrent <= 0)
        {
            battlefinished = true;
            reward = Random.Range(1, 4);
            switch (reward)
            {
                case 1:
                    banner.text = "Enemy defeated: recieved green herb!";
                    GameManager.greenherb++;
                    break;
                case 2:
                    banner.text = "Enemy defeated: recieved blue herb!";
                    GameManager.blueherb++;
                    break;
                case 3:
                    banner.text = "Enemy defeated: recieved red herb!";
                    GameManager.redherb++;
                    break;

            }
        }
    }

    public void characterturn()
    {
        

        if (ourturn)
        {
            

            banner.text = "Opponents turn!";
            enemyhealth.enemyhealthcurrent -= 3;
            ourturn = false;
            if(enemyhealth.enemyhealthcurrent <=0)
            {
                enemydefeated();
            }
        }

       

    }

    public void opponentturn()
    {
        if (!ourturn && enemyhealth.enemyhealthcurrent > 0)
        {
            

            banner.text = "Your turn!";
            GameManager.currenthealth -= 3;
            ourturn=true;
        }

        if (battlefinished)
        {
            
            SceneManager.LoadScene(1);
        }

    }

    public void slash()
    {
        if (ourturn && GameManager.currentstamina >=5)
        {

            GameManager.currentstamina -= 5;
            banner.text = "Opponents turn!";
            enemyhealth.enemyhealthcurrent -= Random.Range(1, 3);
            ourturn = false;
            if (enemyhealth.enemyhealthcurrent <= 0)
            {
                enemydefeated();
            }
        }
        else if(GameManager.currentstamina <= 5)
            banner.text = "Not enough stamina";


    }

    public void lunge()
    {
        if (ourturn && GameManager.currentstamina >= 3)
        {

            GameManager.currentstamina -= 3;
            banner.text = "Opponents turn!";
            enemyhealth.enemyhealthcurrent -= Random.Range(2, 5);
            ourturn = false;
            if (enemyhealth.enemyhealthcurrent <= 0)
            {
                enemydefeated();
            }
        }
        else if(GameManager.currentstamina <= 3)
            banner.text = "Not enough stamina";


    }


}
