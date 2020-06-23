using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRef : MonoBehaviour
{
    public static int money = 0;
    public static int Play1sttime = 1;
    private readonly static string SelectedCharacter = "SelectedCharacter";

    public static void playfirsttime()
    {
        while (Play1sttime == 1)
        {
            PlayerPrefs.SetInt(SelectedCharacter, 2);
            Play1sttime++;
        }
    }    
}
