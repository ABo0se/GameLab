using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScripHandle : MonoBehaviour
{
    public static readonly string FirstPlay = "FirstPlay";

    private void Start()
    {
        PlayerRef.playfirsttime();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainmenuScene");

        }
    }
}
