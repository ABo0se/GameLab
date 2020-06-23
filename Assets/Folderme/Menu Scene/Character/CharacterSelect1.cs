using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect1 : MonoBehaviour
{
    public GameObject Char1;
    public GameObject Char2;
    public GameObject Char3;
    private Vector3 CharacterPos;
    private Vector3 HidePos;
    private int CharacterID = 2;
    private SpriteRenderer Char1Renderer, Char2Renderer, Char3Renderer;


    public void Awake()
    {
        CharacterPos = Char2.transform.localPosition;
        HidePos = Char1.transform.localPosition;
        Char1Renderer = Char1.GetComponent<SpriteRenderer>();
        Char2Renderer = Char2.GetComponent<SpriteRenderer>();
        Char3Renderer = Char3.GetComponent<SpriteRenderer>();

    }
    public void NextCharacter()
    {
        switch (CharacterID)
        {
            case 1:
                Char2Renderer.enabled = true;
                Char2.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                //
                CharacterID++;
                break;
            case 2:
                Char3Renderer.enabled = true;
                Char3.transform.localPosition = CharacterPos;
                //
                Char2Renderer.enabled = false;
                Char2.transform.localPosition = HidePos;
                //
                CharacterID++;
                break;
            case 3:
                Char3Renderer.enabled = false;
                Char3.transform.localPosition = HidePos;
                //
                Char1Renderer.enabled = true;
                Char1.transform.localPosition = CharacterPos;
                //
                CharacterID++;
                Reset();
                break;
            default:
                Reset();
                break;
        }
    }
    public void PreviousCharacter()
    {
        switch (CharacterID)
        {
            case 1:
                Char3Renderer.enabled = true;
                Char3.transform.localPosition = CharacterPos;
                //
                Char1Renderer.enabled = false;
                Char1.transform.localPosition = HidePos;
                //
                CharacterID--;
                Reset();
                break;
            case 2:
                Char1Renderer.enabled = true;
                Char1.transform.localPosition = CharacterPos;
                //
                Char2Renderer.enabled = false;
                Char2.transform.localPosition = HidePos;
                //
                CharacterID--;
                break;
            case 3:
                Char2Renderer.enabled = true;
                Char2.transform.localPosition = CharacterPos;
                //
                Char3Renderer.enabled = false;
                Char3.transform.localPosition = HidePos;
                //
                CharacterID--;
                break;
            default:
                Reset();
                break;
        }
    }
    private void Reset()
    {
        if (CharacterID >= 3)
        {
            CharacterID = 1;
        }
        else if (CharacterID <= 1)
        {
            CharacterID = 3;
        }
    }
}
