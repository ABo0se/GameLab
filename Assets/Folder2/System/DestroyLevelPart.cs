using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLevelPart : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    private readonly string SelectedCharacter = "SelectedCharacter";
    int DestroyTarget2;
    void Start()
    {
        DestroyTarget2 = PlayerPrefs.GetInt(SelectedCharacter);
    }
    void Update()
    {
        if (DestroyTarget2 == 1)
            transform.position = new Vector3(Target1.transform.position.x - 200, 0, 0);
        if (DestroyTarget2 == 2)
            transform.position = new Vector3(Target2.transform.position.x - 200, 0, 0);
        if (DestroyTarget2 == 3)
            transform.position = new Vector3(Target3.transform.position.x - 200, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("LevelPart"))
        {
            Destroy(other.gameObject);
        }
    }
}
