using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseScene : MonoBehaviour
{
    int randomscene;
    public GameObject Floor1;
    public GameObject Floor2;
    public GameObject Floor3;
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;

    private void Start()
    {
        Disableall();
        RandomScene();
    }
    void Disableall()
    {
        Floor1.SetActive(false);
        Floor2.SetActive(false);
        Floor3.SetActive(false);
        Scene1.SetActive(false);
        Scene2.SetActive(false);
        Scene3.SetActive(false);
    }
    void RandomScene()
    {
        randomscene = Random.Range(1, 4);
        Debug.Log(randomscene);
        switch (randomscene)
        {
            case 1:
                Floor1.SetActive(true);
                Scene1.SetActive(true);
                break;
            case 2:
                Floor2.SetActive(true);
                Scene2.SetActive(true);
                break;
            case 3:
                Floor3.SetActive(true);
                Scene3.SetActive(true);
                break;
            default:
                Floor1.SetActive(true);
                Scene1.SetActive(true);
                break;
        }

    }
}
