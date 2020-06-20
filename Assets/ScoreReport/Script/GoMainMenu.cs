using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMainMenu : MonoBehaviour
{
    private readonly string Scoreboost = "Scoreboost";
    private readonly string Timeboost = "Timeboost";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainmenuScene");
        }
    }
}
