using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            StartCoroutine(destroyobsta());
        }
    }
    IEnumerator destroyobsta()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
