using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBoost1 : MonoBehaviour
{
    public Toggle TimeBooster;
    public Toggle ScoreBooster;
    static int CostTimeboost = 200;
    static int CostScoreboost = 300;
    private readonly string Scoreboost = "Scoreboost";
    private readonly string Timeboost = "Timeboost";

    private void Update()
    {
        if (PlayerRef.money - CostTimeboost < 0 && TimeBooster.isOn == false)
            TimeBooster.interactable = false;
        else
            TimeBooster.interactable = true;
        //
        if (PlayerRef.money - CostScoreboost < 0 && ScoreBooster.isOn == false)
            ScoreBooster.interactable = false;
        else
            ScoreBooster.interactable = true;
    }
    public void TimeOnValueChange()
    {
        if (TimeBooster.isOn == true)
        {
            PlayerRef.money -= CostTimeboost;
            PlayerPrefs.SetInt(Timeboost, 1);

        }
        else if (TimeBooster.isOn == false)
        {
            PlayerRef.money += CostTimeboost;
            PlayerPrefs.SetInt(Timeboost, 0);
        }
    }
    public void ScoreOnValueChange()
     {
        if (ScoreBooster.isOn == true)
        {
            PlayerRef.money -= CostScoreboost;
            PlayerPrefs.SetInt(Scoreboost, 1);
        }
        else if (ScoreBooster.isOn == false)
        {
            PlayerRef.money += CostScoreboost;
            PlayerPrefs.SetInt(Scoreboost, 0);
        }
    }    
}
