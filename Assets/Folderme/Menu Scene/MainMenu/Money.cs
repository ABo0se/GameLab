using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    void Start()
    {
    }
    public void Spendmoney(int CharacterCost)
    {
        if (PlayerRef.money - CharacterCost >= 0)
        {
            PlayerRef.money -= CharacterCost;
        }
        else
            Debug.Log("You don't have enough money.");
    }
    public void AbilityCost(int AbilityCost)
    {
        if (PlayerRef.money - AbilityCost >= 0)
        {
            PlayerRef.money -= AbilityCost;
        }
        else
            Debug.Log("You don't have enough money.");
    }
    public void Gainmoney(int worth)
    {
        PlayerRef.money += worth;
    }
}