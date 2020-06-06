using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public Button ButtonBuyChar1;
    public Button ButtonSelectChar1;
    public Button ButtonSelectChar2;
    private Vector3 ShowPosButton;
    private Vector3 HidePosButton;
    private Button ButtonBuyChar1Renderer, ButtonSelectChar2Renderer, ButtonSelectChar1Renderer;
    private int CharacterID = 2;

    public void Awake()
    {
        ShowPosButton = ButtonSelectChar2.transform.localPosition;
        HidePosButton = ButtonBuyChar1.transform.localPosition;
        ButtonBuyChar1Renderer = ButtonBuyChar1.GetComponent<Button>();
        ButtonSelectChar1Renderer = ButtonSelectChar1.GetComponent<Button>();
        ButtonSelectChar2Renderer = ButtonSelectChar2.GetComponent<Button>();
    }
    public void NextCharacter()
    {
        switch (CharacterID)
        {
            case 1:
                ButtonSelectChar2Renderer.enabled = true;
                ButtonSelectChar2.transform.localPosition = ShowPosButton;
                //
                if(Shop.soldChar1 == true)
                {
                    ButtonSelectChar1Renderer.enabled = false;
                    ButtonSelectChar1.transform.localPosition = HidePosButton;
                }   
                else if (Shop.soldChar1 == false)
                {
                    ButtonBuyChar1Renderer.enabled = false;
                    ButtonBuyChar1.transform.localPosition = HidePosButton;
                }
                //
                CharacterID++;
                break;
            case 2:
                if (Shop.soldChar1 == true)
                {
                    ButtonSelectChar1Renderer.enabled = true;
                    ButtonSelectChar1.transform.localPosition = ShowPosButton;
                }
                else if (Shop.soldChar1 == false)
                {
                    ButtonBuyChar1Renderer.enabled = true;
                    ButtonBuyChar1.transform.localPosition = ShowPosButton;
                }
                //
                ButtonSelectChar2Renderer.enabled = false;
                ButtonSelectChar2.transform.localPosition = HidePosButton;
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
                ButtonSelectChar2Renderer.enabled = true;
                ButtonSelectChar2.transform.localPosition = ShowPosButton;
                //
                if (Shop.soldChar1 == true)
                {
                    ButtonSelectChar1Renderer.enabled = false;
                    ButtonSelectChar1.transform.localPosition = HidePosButton;
                }
                else if (Shop.soldChar1 == false)
                {
                    ButtonBuyChar1Renderer.enabled = false;
                    ButtonBuyChar1.transform.localPosition = HidePosButton;
                }
                //
                CharacterID--;
                Reset();
                break;
            case 2:
                if (Shop.soldChar1 == true)
                {
                    ButtonSelectChar1Renderer.enabled = true;
                    ButtonSelectChar1.transform.localPosition = ShowPosButton;
                }
                else if (Shop.soldChar1 == false)
                {
                    ButtonBuyChar1Renderer.enabled = true;
                    ButtonBuyChar1.transform.localPosition = ShowPosButton;
                }
                //
                ButtonSelectChar2Renderer.enabled = false;
                ButtonSelectChar2.transform.localPosition = HidePosButton;
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
