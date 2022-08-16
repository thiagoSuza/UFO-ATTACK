using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassicPanelCanvas : MonoBehaviour
{
    public GameObject pausePanel, winPanel,bossFinal;
    public GameObject optionsMenu;
    

    public void Start()
    {
        
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        winPanel.SetActive(false);
        optionsMenu.SetActive(false);
    }
    private void Update()
    {
        Pauser();
        Win();
    }


    public void Win()
    {
        if (bossFinal.activeSelf)
        {
            if (BossFinal.instance.winGame == true)
            {
                winPanel.SetActive(true);
                Time.timeScale = 0f;

            }
            else if(bossFinal == null)
            {
                bossFinal = null;
            }
        }
        
        
        
    }
    public void Pauser()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }

    public void ClassicExitButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void ClassicOptionsButton()
    {
        // CONSTRUIR PAINEL
    }

    public void ClassicResumeButton()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);


    }

    public void ClassicTryAgainButton()
    {        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);        
    }

    public void OpenMenuOptions()
    {
        optionsMenu.SetActive(true);
    }

    public void CloseMenuOptions()
    {
        optionsMenu.SetActive(false);
    }

   
}
