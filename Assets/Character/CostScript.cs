﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CostScript : MonoBehaviour
{
    public TextMeshProUGUI CostChar1;
    public TextMeshProUGUI CostChar2;
    private Vector3 ShowPosCost;
    private Vector3 HidePosCost;
    private TextMeshProUGUI CostChar1Renderer, CostChar2Renderer;
    private int CharacterID = 2;

    public void Awake()
    {
        ShowPosCost = CostChar2.transform.localPosition;
        HidePosCost = CostChar1.transform.localPosition;
        CostChar1Renderer = CostChar1.GetComponent<TextMeshProUGUI>();
        CostChar2Renderer = CostChar2.GetComponent<TextMeshProUGUI>();

    }
    public void NextCharacter()
    {
        switch (CharacterID)
        {
            case 1:
                CostChar2Renderer.enabled = true;
                CostChar2.transform.localPosition = ShowPosCost;
                //
                CostChar1Renderer.enabled = false;
                CostChar1.transform.localPosition = HidePosCost;
                //
                CharacterID++;
                break;
            case 2:
                CostChar1Renderer.enabled = true;
                CostChar1.transform.localPosition = ShowPosCost;
                //
                CostChar2Renderer.enabled = false;
                CostChar2.transform.localPosition = HidePosCost;
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
                CostChar2Renderer.enabled = true;
                CostChar2.transform.localPosition = ShowPosCost;
                //
                CostChar1Renderer.enabled = false;
                CostChar1.transform.localPosition = HidePosCost;
                //
                CharacterID--;
                Reset();
                break;
            case 2:
                CostChar1Renderer.enabled = true;
                CostChar1.transform.localPosition = ShowPosCost;
                //
                CostChar2Renderer.enabled = false;
                CostChar2.transform.localPosition = HidePosCost;
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
        if (CharacterID >= 2)
        {
            CharacterID = 1;
        }
        else if (CharacterID <= 1)
        {
            CharacterID = 2;
        }
    }
}
