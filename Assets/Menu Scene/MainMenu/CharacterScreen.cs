using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScreen : MonoBehaviour
{
    public GameObject Char1, Char2, Char3;
    private Vector3 CharacterPos, HidePos;
    private SpriteRenderer MySprite;
    private readonly string SelectedCharacter = "SelectedCharacter";
    private SpriteRenderer Char1Renderer, Char2Renderer, Char3Renderer;
    int Character;
    void Awake()
    {
        MySprite = this.GetComponent<SpriteRenderer>();
        CharacterPos = Char2.transform.localPosition;
        HidePos = Char1.transform.localPosition;
        Char1Renderer = Char1.GetComponent<SpriteRenderer>();
        Char2Renderer = Char2.GetComponent<SpriteRenderer>();
        Char3Renderer = Char3.GetComponent<SpriteRenderer>();
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
                Debug.Log("1");
                break;
            case 2:
                Char2Renderer.enabled = true;
                Char2.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                Char3Renderer.enabled = false;
                Char3.transform.localPosition = HidePos;
                Debug.Log("2");
                break;
            case 3:
                Char3Renderer.enabled = true;
                Char3.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                Char2Renderer.enabled = false;
                Char2.transform.localPosition = HidePos;
                Debug.Log("3");
                break;
            default:
                Char2Renderer.enabled = true;
                Char2.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                Char3Renderer.enabled = false;
                Char3.transform.localPosition = HidePos;
                Debug.Log("4");
                break;
        }    
    }
}
