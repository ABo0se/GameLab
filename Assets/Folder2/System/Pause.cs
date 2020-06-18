using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;
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
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause2()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
