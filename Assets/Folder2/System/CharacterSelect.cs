using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public GameObject Char1, Char2, Char3;
    private readonly string SelectedCharacter = "SelectedCharacter";

    int Characteruse;

    void Awake()
    {
        Char1.SetActive(false);
        Char2.SetActive(false);
        Char3.SetActive(false);
        Characteruse = PlayerPrefs.GetInt(SelectedCharacter);
        switch (Characteruse)
        {
            case 1:
                Char1.SetActive(true);
                break;
            case 2:
                Char2.SetActive(true);
                break;
            case 3:
                Char3.SetActive(true);
                break;
            default:
                Char2.SetActive(true);
                break;
        }
    }
}
