using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RStarScore : MonoBehaviour
{
    // Start is called before the first frame update
    public int R_StarScore = 500;
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.instance.R_StarChangeScore(R_StarScore);
        }
    }
}
