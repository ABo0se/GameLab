using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    private void Start()
    {

    }
    public readonly string SelectedCharacter = "SelectedCharacter";
    public void Select_Char1()
    {
        PlayerPrefs.SetInt(SelectedCharacter, 1);
    }
    public void Select_Char2()
    {
        PlayerPrefs.SetInt(SelectedCharacter, 2);
    }
    public void Select_Char3()
    {
        PlayerPrefs.SetInt(SelectedCharacter, 3);
    }
}
