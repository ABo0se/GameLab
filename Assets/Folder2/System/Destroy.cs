using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    int DestroyTarget;
    void Start()
    {
        //(realcode) int DestroyTarget = PlayerPrefs.GetInt(SelectedCharacter);
        DestroyTarget = 2;
    }
    void Update()
    {
        if (DestroyTarget == 1)
            transform.position = new Vector3(Target1.transform.position.x - 30, 0, 0);
        if (DestroyTarget == 2)
            transform.position = new Vector3(Target2.transform.position.x - 30, 0, 0);
        if (DestroyTarget == 3)
            transform.position = new Vector3(Target3.transform.position.x - 30, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Life"))
        {
            Destroy(other.gameObject);
        }
    }
}
