using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ability1_3 : MonoBehaviour
{
    public TextMeshProUGUI AbilityChar1;
    public TextMeshProUGUI AbilityChar2;
    public TextMeshProUGUI AbilityChar3;
    private Vector3 ShowPosAbility;
    private Vector3 HidePosAbility;
    private TextMeshProUGUI AbilityChar1Renderer, AbilityChar2Renderer, AbilityChar3Renderer;
    private int CharacterID = 2;

    public void Awake()
    {
        ShowPosAbility = AbilityChar2.transform.localPosition;
        HidePosAbility = AbilityChar1.transform.localPosition;
        AbilityChar1Renderer = AbilityChar1.GetComponent<TextMeshProUGUI>();
        AbilityChar2Renderer = AbilityChar2.GetComponent<TextMeshProUGUI>();
        AbilityChar3Renderer = AbilityChar3.GetComponent<TextMeshProUGUI>();
    }
    public void NextCharacter()
    {
        switch (CharacterID)
        {
            case 1:
                AbilityChar2Renderer.enabled = true;
                AbilityChar2.transform.localPosition = ShowPosAbility;
                //
                AbilityChar1Renderer.enabled = false;
                AbilityChar1.transform.localPosition = HidePosAbility;
                //
                CharacterID++;
                break;
            case 2:
                AbilityChar3Renderer.enabled = true;
                AbilityChar3.transform.localPosition = ShowPosAbility;
                //
                AbilityChar2Renderer.enabled = false;
                AbilityChar2.transform.localPosition = HidePosAbility;
                //
                CharacterID++;
                break;
            case 3:
                AbilityChar1Renderer.enabled = true;
                AbilityChar1.transform.localPosition = ShowPosAbility;
                //
                AbilityChar3Renderer.enabled = false;
                AbilityChar3.transform.localPosition = HidePosAbility;
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
                AbilityChar3Renderer.enabled = true;
                AbilityChar3.transform.localPosition = ShowPosAbility;
                //
                AbilityChar1Renderer.enabled = false;
                AbilityChar1.transform.localPosition = HidePosAbility;
                //
                CharacterID--;
                Reset();
                break;
            case 2:
                AbilityChar1Renderer.enabled = true;
                AbilityChar1.transform.localPosition = ShowPosAbility;
                //
                AbilityChar2Renderer.enabled = false;
                AbilityChar2.transform.localPosition = HidePosAbility;
                //
                CharacterID--;
                break;
            case 3:
                AbilityChar2Renderer.enabled = true;
                AbilityChar2.transform.localPosition = ShowPosAbility;
                //
                AbilityChar3Renderer.enabled = false;
                AbilityChar3.transform.localPosition = HidePosAbility;
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
