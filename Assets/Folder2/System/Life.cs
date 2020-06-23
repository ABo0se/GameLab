using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public static Life instance;
    public TextMeshProUGUI text3;
    private readonly string SelectedCharacter = "SelectedCharacter";
    private readonly string Summaryscore = "Summaryscore";
    private readonly string Summarymoney = "Summarymoney";
    int Characterusedlife;
    int maxlife;
    int life;
    /// 

    void Start()
    {
        if (instance == null)
            instance = this;
        Characterusedlife = PlayerPrefs.GetInt(SelectedCharacter);
        if (Characterusedlife == 3)
        {
            maxlife = 3;
            life = 3;
            text3.text = life.ToString();
        }
        else
        {
            maxlife = 2;
            life = 2;
            text3.text = life.ToString();
        }
    }

    public void ItemplusLife(int lifeValue)
    {
        if (life + lifeValue <= maxlife)
        {
            life += lifeValue;
            text3.text = life.ToString();
        }
    }
    public void RemoveLife()
    {
        if (life - 1 > 0)
        {
            life--;
            text3.text = life.ToString();
        }
        else if (life - 1 <= 0)
        {
            Time.timeScale = 1f;
            Pause.GameIsPaused = false;
            PlayerPrefs.SetInt(Summaryscore, Score.score2);
            PlayerPrefs.SetInt(Summarymoney, MoneyIngame.money);
            SceneManager.LoadScene("ResultScore");
        }
    }
}