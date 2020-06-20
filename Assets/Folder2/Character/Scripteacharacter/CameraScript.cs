using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    int camerafollowtarget;
    private readonly string SelectedCharacter = "SelectedCharacter";
    // Start is called before the first frame update
    void Start()
    {
        camerafollowtarget = PlayerPrefs.GetInt(SelectedCharacter);
    }

    // Update is called once per frame
    void Update()
    {
        if (camerafollowtarget == 1)
            transform.position = new Vector3(Target1.transform.position.x + 10.5f, 0, -10);
        if (camerafollowtarget == 2)
            transform.position = new Vector3(Target2.transform.position.x + 10.5f, 0, -10);
        if (camerafollowtarget == 3)
            transform.position = new Vector3(Target3.transform.position.x + 10.5f, 0, -10);
    }
}
