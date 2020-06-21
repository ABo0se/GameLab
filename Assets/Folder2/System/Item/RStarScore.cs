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
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            StartCoroutine(destroystar500());
        }
    }
    IEnumerator destroystar500()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
