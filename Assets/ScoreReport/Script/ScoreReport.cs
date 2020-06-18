using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreReport : MonoBehaviour
{
    public static ScoreReport instance;
    public TextMeshProUGUI text;
    private readonly string Summaryscore = "Summaryscore";
    int scori;
    void Start()
    {
        if (instance == null)
            instance = this;
        scori = PlayerPrefs.GetInt(Summaryscore);
        text.text = scori.ToString();
    }
}
