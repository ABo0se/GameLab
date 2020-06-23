using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameScript : MonoBehaviour
{
    public TextMeshProUGUI NameChar1;
    public TextMeshProUGUI NameChar2;
    public TextMeshProUGUI NameChar3;
    private Vector3 ShowPosName;
    private Vector3 HidePosName;
    private TextMeshProUGUI NameChar1Renderer, NameChar2Renderer, NameChar3Renderer;
    private int CharacterID = 2;

    public void Awake()
    {
        ShowPosName = NameChar2.transform.localPosition;
        HidePosName = NameChar1.transform.localPosition;
        NameChar1Renderer = NameChar1.GetComponent<TextMeshProUGUI>();
        NameChar2Renderer = NameChar2.GetComponent<TextMeshProUGUI>();
        NameChar3Renderer = NameChar3.GetComponent<TextMeshProUGUI>();
    }
    public void NextCharacter()
    {
        switch (CharacterID)
        {
            case 1:
                NameChar2Renderer.enabled = true;
                NameChar2.transform.localPosition = ShowPosName;
                //
                NameChar1Renderer.enabled = false;
                NameChar1.transform.localPosition = HidePosName;
                //
                CharacterID++;
                break;
            case 2:
                NameChar3Renderer.enabled = true;
                NameChar3.transform.localPosition = ShowPosName;
                //
                NameChar2Renderer.enabled = false;
                NameChar2.transform.localPosition = HidePosName;
                //
                CharacterID++;
                break;
            case 3:
                NameChar1Renderer.enabled = true;
                NameChar1.transform.localPosition = ShowPosName;
                //
                NameChar3Renderer.enabled = false;
                NameChar3.transform.localPosition = HidePosName;
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
                NameChar3Renderer.enabled = true;
                NameChar3.transform.localPosition = ShowPosName;
                //
                NameChar1Renderer.enabled = false;
                NameChar1.transform.localPosition = HidePosName;
                //
                CharacterID--;
                Reset();
                break;
            case 2:
                NameChar1Renderer.enabled = true;
                NameChar1.transform.localPosition = ShowPosName;
                //
                NameChar2Renderer.enabled = false;
                NameChar2.transform.localPosition = HidePosName;
                //
                CharacterID--;
                break;
            case 3:
                NameChar2Renderer.enabled = true;
                NameChar2.transform.localPosition = ShowPosName;
                //
                NameChar3Renderer.enabled = false;
                NameChar3.transform.localPosition = HidePosName;
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
