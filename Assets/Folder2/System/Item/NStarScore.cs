using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NStarScore : MonoBehaviour
{
    public int StarScore = 10;
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.instance.StarChangeScore(StarScore);
        }
    }
}
