using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Pause : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pause_button;
    public GameObject pause_image_menu;
    public GameObject game_over_image_menu;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Countiniue();
            }

        }

        if (GameObject.Find("Player") == null)
        {
            Invoke("Game_Over", 0.5f);
           
        }


    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pause_button.SetActive(false);
        pause_image_menu.SetActive(true);
    }

    public void Countiniue()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pause_button.SetActive(true);
        pause_image_menu.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SpaceShooter");
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void Game_Over()
    {
        isPaused = true;
        game_over_image_menu.SetActive(true);
       
        Time.timeScale = 0f;
    }

    
}
