using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRef : MonoBehaviour
{
    public static int money = 1500;
    private readonly string SelectedCharacter = "SelectedCharacter";
    private void Start()
    {
        PlayerPrefs.SetInt(SelectedCharacter, 2);
    }

}
