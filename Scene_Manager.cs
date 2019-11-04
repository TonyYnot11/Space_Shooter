using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{

    public GameObject start_button;
    public GameObject exit_button;
    public GameObject control_button;
    public GameObject control_image;
    public void StartGame()
    {
        SceneManager.LoadScene("SpaceShooter");

    }

    public void Exit()
    {
        Application.Quit();

    }

    public void Controlls()
    {
        start_button.SetActive(false);
        exit_button.SetActive(false);
        control_button.SetActive(false);
        control_image.SetActive(true);


    }
}
