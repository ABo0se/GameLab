using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRStarScore : MonoBehaviour
{
    // Start is called before the first frame update
    public int SR_StarScore = 2000;
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.instance.SR_StarChangeScore(SR_StarScore);
        }
    }
}
