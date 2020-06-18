using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScoreScene : MonoBehaviour
{
    public void ResultScene()
    {
        Pause.GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("ResultScore");
    }
}
