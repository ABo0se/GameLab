using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetailScript : MonoBehaviour
{
    public TextMeshProUGUI DetailChar1;
    public TextMeshProUGUI DetailChar2;
    public TextMeshProUGUI DetailChar3;
    private Vector3 ShowPosdetail;
    private Vector3 HidePosdetail;
    private TextMeshProUGUI DetailChar1Renderer, DetailChar2Renderer, DetailChar3Renderer;
    private int CharacterID = 2;

    public void Awake()
    {
        ShowPosdetail = DetailChar2.transform.localPosition;
        HidePosdetail = DetailChar1.transform.localPosition;
        DetailChar1Renderer = DetailChar1.GetComponent<TextMeshProUGUI>();
        DetailChar2Renderer = DetailChar2.GetComponent<TextMeshProUGUI>();
        DetailChar3Renderer = DetailChar3.GetComponent<TextMeshProUGUI>();
    }
    public void NextCharacter()
    {
        switch (CharacterID)
        {
            case 1:
                DetailChar2Renderer.enabled = true;
                DetailChar2.transform.localPosition = ShowPosdetail;
                //
                DetailChar1Renderer.enabled = false;
                DetailChar1.transform.localPosition = HidePosdetail;
                //
                CharacterID++;
                break;
            case 2:
                DetailChar3Renderer.enabled = true;
                DetailChar3.transform.localPosition = ShowPosdetail;
                //
                DetailChar2Renderer.enabled = false;
                DetailChar2.transform.localPosition = HidePosdetail;
                //
                CharacterID++;
                break;
            case 3:
                DetailChar1Renderer.enabled = true;
                DetailChar1.transform.localPosition = ShowPosdetail;
                //
                DetailChar3Renderer.enabled = false;
                DetailChar3.transform.localPosition = HidePosdetail;
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
                DetailChar3Renderer.enabled = true;
                DetailChar3.transform.localPosition = ShowPosdetail;
                //
                DetailChar1Renderer.enabled = false;
                DetailChar1.transform.localPosition = HidePosdetail;
                //
                CharacterID--;
                Reset();
                break;
            case 2:
                DetailChar1Renderer.enabled = true;
                DetailChar1.transform.localPosition = ShowPosdetail;
                //
                DetailChar2Renderer.enabled = false;
                DetailChar2.transform.localPosition = HidePosdetail;
                //
                CharacterID--;
                break;
            case 3:
                DetailChar2Renderer.enabled = true;
                DetailChar2.transform.localPosition = ShowPosdetail;
                //
                DetailChar3Renderer.enabled = false;
                DetailChar3.transform.localPosition = HidePosdetail;
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

