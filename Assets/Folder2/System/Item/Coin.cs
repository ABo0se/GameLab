using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
    }
    public int ScoreValue = 10;
    public int MoneyValue = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.instance.CoinChangeScore(ScoreValue);
            MoneyIngame.instance.CoinChangeMoney(MoneyValue);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            StartCoroutine(destroycoin());
        }
    }
    IEnumerator destroycoin()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
