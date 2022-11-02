using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Dialogue UI")]
    [SerializeField] private GameObject pausePanel;
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseButtonPressed()
    {
        Debug.Log("fuck");
        pausePanel.SetActive(true);
    }
    public void Resume()
    {
        pausePanel.SetActive(false);
    }
    public void QuitToMainMenu()
    {
        Debug.Log("hi");
        Application.Quit();
    }

}
