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
        }
    }
}
