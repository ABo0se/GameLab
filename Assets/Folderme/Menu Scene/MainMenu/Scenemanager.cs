﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    public void GamePlayScene()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
