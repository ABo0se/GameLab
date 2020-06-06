using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public Button BuyChar1;
    public Button SelectChar1;
    public Button Refbutsolotion;
    public Button Refbuthidesolotion;
    private Vector3 ShowPosdetail;
    private Vector3 HidePosdetail;
    public static bool soldChar1 = false;
    int Char1cost = 500;
    public readonly string SelectedCharacter = "SelectedCharacter";
    private Button SelectChar1Renderer;
    private Button BuyChar1Renderer;


    void Start()
    {
        SelectChar1.enabled = false;
        PlayerPrefs.SetInt(SelectedCharacter, 2);
        ShowPosdetail = Refbutsolotion.transform.localPosition;
        HidePosdetail = Refbuthidesolotion.transform.localPosition;
    }
    void Update()
    {
        if (PlayerRef.money >= Char1cost && soldChar1 == false)
            BuyChar1.interactable = true;
        else
            BuyChar1.interactable = false;
    }
    public void Buy_Char1()
    {
        PlayerRef.money -= 500;
        soldChar1 = true;
            BuyChar1Renderer = BuyChar1.GetComponent<Button>();
            BuyChar1Renderer.enabled = false;
            BuyChar1.transform.localPosition = HidePosdetail;
            SelectChar1Renderer = SelectChar1.GetComponent<Button>();
            SelectChar1Renderer.enabled = true;
            SelectChar1.transform.localPosition = ShowPosdetail;
    }

}
