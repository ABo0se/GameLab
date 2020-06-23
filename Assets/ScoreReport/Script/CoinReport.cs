using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinReport : MonoBehaviour
{
    public static CoinReport instance;
    public TextMeshProUGUI text;
    private readonly string Summarymoney = "Summarymoney";
    int moni;
    void Start()
    {
        if (instance == null)
            instance = this;
        moni = PlayerPrefs.GetInt(Summarymoney);
        text.text = moni.ToString();
        PlayerRef.money += moni;
    }
}
