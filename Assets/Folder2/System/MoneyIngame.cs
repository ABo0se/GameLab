using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyIngame : MonoBehaviour
{
    public static MoneyIngame instance;
    public TextMeshProUGUI text;
    private readonly string Summarymoney = "Summarymoney";
    public static int money;

    void Start()
    {
        if (instance == null)
            instance = this;
        money = 0;
    }

    public void CoinChangeMoney(int MoneyValue)
    {
        money += MoneyValue;
        text.text = money.ToString();
    }
    public void Leftgame2()
    {
        PlayerPrefs.SetInt(Summarymoney, money);
    }
}
