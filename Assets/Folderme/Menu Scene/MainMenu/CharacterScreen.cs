using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScreen : MonoBehaviour
{
    public GameObject Char1, Char2, Char3;
    private Vector3 CharacterPos, HidePos;
    private readonly string SelectedCharacter = "SelectedCharacter";
    private SpriteRenderer Char1Renderer, Char2Renderer, Char3Renderer;
    int Character;
    void Awake()
    {
        CharacterPos = Char2.transform.localPosition;
        HidePos = Char1.transform.localPosition;
        Char1Renderer = Char1.GetComponent<SpriteRenderer>();
        Char2Renderer = Char2.GetComponent<SpriteRenderer>();
        Char3Renderer = Char3.GetComponent<SpriteRenderer>();

        while (PlayerRef.Play1sttime == 1)
        {
            PlayerPrefs.SetInt(SelectedCharacter, 2);
            PlayerRef.Play1sttime++;
        }
    }
    void Update()
    {
        Character = PlayerPrefs.GetInt(SelectedCharacter);
        switch (Character)
        {
            case 1:
                Char1Renderer.enabled = true;
                Char1.transform.localPosition = CharacterPos;
                //
                Char2Renderer.enabled = false;
                Char2.transform.localPosition = HidePos;
                Char3Renderer.enabled = false;
                Char3.transform.localPosition = HidePos;
                break;
            case 2:
                Char2Renderer.enabled = true;
                Char2.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                Char3Renderer.enabled = false;
                Char3.transform.localPosition = HidePos;
                break;
            case 3:
                Char3Renderer.enabled = true;
                Char3.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                Char2Renderer.enabled = false;
                Char2.transform.localPosition = HidePos;
                break;
            default:
                Char2Renderer.enabled = true;
                Char2.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                Char3Renderer.enabled = false;
                Char3.transform.localPosition = HidePos;
                break;
        }    
    }
}
