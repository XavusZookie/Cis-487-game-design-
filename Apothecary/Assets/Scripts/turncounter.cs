using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class turncounter : MonoBehaviour
{


    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    public enemyone firstwolf;
    public enemyone secondwolf;
    public enemyone thirdwolf;

   
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
        spawnenemy();
        
    }


    public void spawnenemy()
    {
        if (GameManager.level <= 9)
        {
            enemy1.SetActive(true);
        }
        else if (GameManager.level <= 15)
        {
            enemy3.SetActive(true);
            enemy2.SetActive(true);
        }
        else
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
        }



    }


    // Update is called once per frame
    void Update()
    {

    }

    public void enemydefeated()
    {
        if ((enemy1.activeSelf == false || firstwolf.currenthealth <= 0) && (enemy2.activeSelf == false || secondwolf.currenthealth <= 0) && (enemy3.activeSelf == false || thirdwolf.currenthealth <= 0))
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

    public void lunge()
    {

        if (ourturn && GameManager.currentstamina >= 3)
        {

            GameManager.currentstamina -= 3;
            banner.text = "Opponents turn!";


            if (enemy1.activeSelf == true)
            {
                firstwolf.currenthealth -= Random.Range(GameManager.damagerange-GameManager.damagevariance, GameManager.damagerange+1 );
            }
            else if(enemy2.activeSelf == true)
            {
                 secondwolf.currenthealth -= Random.Range(GameManager.damagerange - GameManager.damagevariance, GameManager.damagerange+1 );
               
            }
            else if (enemy3.activeSelf == true)
            {
                thirdwolf.currenthealth -= Random.Range(GameManager.damagerange - GameManager.damagevariance, GameManager.damagerange+1 );

            }
            ourturn = false;
            if ((enemy1.activeSelf == false||firstwolf.currenthealth<=0) && (enemy2.activeSelf == false || secondwolf.currenthealth <= 0) && (enemy3.activeSelf == false || thirdwolf.currenthealth <= 0))
            {

                enemydefeated();
            }
        }
        else if (GameManager.currentstamina <= 5)
            banner.text = "Not enough stamina";


    }

    public void opponentturn()
    {


        if (!ourturn && enemy1.activeSelf == true )
        {


            banner.text = "Your turn!";
            GameManager.currenthealth -= Random.Range(firstwolf.damagerange -2, firstwolf.damagerange+1);
     

        }
        if (!ourturn && enemy2.activeSelf == true)
        {


            banner.text = "Your turn!";
            GameManager.currenthealth -= Random.Range(secondwolf.damagerange - 2, secondwolf.damagerange+1);
     

        }
        if (!ourturn && enemy3.activeSelf == true)
        {


            banner.text = "Your turn!";
            GameManager.currenthealth -= Random.Range(thirdwolf.damagerange - 2, thirdwolf.damagerange+1);

        }

 ourturn = true;


        if (battlefinished)
        {
            
            SceneManager.LoadScene(1);
        }

    }

    public void slash()
    {

        if (ourturn && GameManager.currentstamina >= 5)
        {

            GameManager.currentstamina -= 5;
            banner.text = "Opponents turn!";


            if (enemy1.activeSelf == true)
            {
                firstwolf.currenthealth -= Random.Range(GameManager.damagerange - GameManager.damagevariance-2, GameManager.damagerange -1);
            }
            if (enemy2.activeSelf == true)
            {
                secondwolf.currenthealth -= Random.Range(GameManager.damagerange - GameManager.damagevariance-2, GameManager.damagerange -1);

            }
            if (enemy3.activeSelf == true)
            {
                thirdwolf.currenthealth -= Random.Range(GameManager.damagerange - GameManager.damagevariance-2, GameManager.damagerange -1);

            }
            ourturn = false;
            if ((enemy1.activeSelf == false || firstwolf.currenthealth <= 0) && (enemy2.activeSelf == false || secondwolf.currenthealth <= 0) && (enemy3.activeSelf == false || thirdwolf.currenthealth <= 0))
            {

                enemydefeated();
            }
        }
        else if (GameManager.currentstamina <= 5)
            banner.text = "Not enough stamina";


    }
    

}
