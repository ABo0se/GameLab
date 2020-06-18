using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI text2;
    private readonly string SelectedCharacter = "SelectedCharacter";
    private readonly string Scoreboost = "Scoreboost";
    private readonly string Summaryscore = "Summaryscore";
    int Characteruse;
    public static int score;
    public static int score2;
    float scoremultiplyer;
    int scoreboost;
    float scoremulti1;
    float scoremulti2;

    void Start()
    {
        if (instance == null)
            instance = this;
        score = 0;
        score2 = 0;
        Characteruse = PlayerPrefs.GetInt(SelectedCharacter);
        scoreboost = PlayerPrefs.GetInt(Scoreboost);
        switch (Characteruse)
        {
            case 2:
                scoremulti1 = 0.1f;
                break;
            case 3:
                scoremulti1 = 0f;
                break;
            case 1:
                scoremulti1 = 0f;
                break;
            default:
                scoremulti1 = 0.1f;
                break;
        }
        switch (scoreboost)
        {
            case 1:
                scoremulti2 = 0.2f;
                break;
            case 0:
                scoremulti2 = 0f;
                break;
            default:
                scoremulti2 = 0;
                break;
        }
        scoremultiplyer = 1 + scoremulti1 + scoremulti2;
    }
    public void CoinChangeScore(int ScoreValue)
    {
        score += ScoreValue;
        score2 = Mathf.RoundToInt(score * scoremultiplyer);
        text2.text = score2.ToString();
    }
    //////------------- ITEM SCORE --------------/////////

    public void StarChangeScore(int StarScore)
    {
        score += StarScore;
        score2 = Mathf.RoundToInt(score * scoremultiplyer);
        text2.text = score2.ToString();
    }
    public void R_StarChangeScore(int R_StarScore)
    {
        score += R_StarScore;
        score2 = Mathf.RoundToInt(score * scoremultiplyer);
        text2.text = score2.ToString();
    }
    public void SR_StarChangeScore(int SR_StarScore)
    {
        score += SR_StarScore;
        score2 = Mathf.RoundToInt(score * scoremultiplyer);
        text2.text = score2.ToString();
    }
    //////////////////////
    public void Leftgame()
        {
            PlayerPrefs.SetInt(Summaryscore, score2);
        }
}
