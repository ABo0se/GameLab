using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCoin : MonoBehaviour
{
    void Start()
    {
    }
    public int ScoreValue = 100;
    public int MoneyValue = 10;
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
            StartCoroutine(destroybigcoin());
        }
    }
    IEnumerator destroybigcoin()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
