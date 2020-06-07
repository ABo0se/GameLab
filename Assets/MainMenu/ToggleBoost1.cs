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

    private void Update()
    {
        if (PlayerRef.money - CostTimeboost <= 0 && TimeBooster.isOn == false)
            TimeBooster.interactable = false;
        else
            TimeBooster.interactable = true;
        //
        if (PlayerRef.money - CostScoreboost <= 0 && ScoreBooster.isOn == false)
            ScoreBooster.interactable = false;
        else
            ScoreBooster.interactable = true;
    }
    public void TimeOnValueChange()
    {
        if (TimeBooster.isOn == true)
        {
            PlayerRef.money -= CostTimeboost;
        }
        else if (TimeBooster.isOn == false)
        {
            PlayerRef.money += CostTimeboost;
        }
    }
    public void ScoreOnValueChange()
     {
        if (ScoreBooster.isOn == true)
        {
            PlayerRef.money -= CostScoreboost;
        }
        else if (ScoreBooster.isOn == false)
        {
            PlayerRef.money += CostScoreboost;
        }
    }    
}
