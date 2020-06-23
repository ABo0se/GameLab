using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;
    private readonly string Timescale = "Timescale";

    private void Start()
    {
        GameIsPaused = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
                Resume();
            else
                Pause2();
        }
    }
    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = PlayerPrefs.GetFloat(Timescale);
        GameIsPaused = false;
    }
    public void Pause2()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Quit()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetFloat("Timescale", 1f);
    }

}
