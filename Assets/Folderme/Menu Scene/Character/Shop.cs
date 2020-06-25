using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public Button BuyChar1;
    public Button SelectChar1;
    public Button BuyChar3;
    public Button SelectChar3;
    public Button Refbutsolotion;
    public Button Refbuthidesolotion;
    private Vector3 ShowPosdetail;
    private Vector3 HidePosdetail;
    public static bool soldChar1 = false;
    public static bool soldChar3 = false;
    int Char1cost = 500;
    int Char3cost = 1000;
    public readonly string SelectedCharacter = "SelectedCharacter";
    private Button SelectChar1Renderer;
    private Button BuyChar1Renderer;
    private Button SelectChar3Renderer;
    private Button BuyChar3Renderer;


    void Start()
    {
        SelectChar1.enabled = false;
        SelectChar3.enabled = false;
        ShowPosdetail = Refbutsolotion.transform.localPosition;
        HidePosdetail = Refbuthidesolotion.transform.localPosition;
    }
    public void Update()
    {
        if (PlayerRef.money >= Char1cost && soldChar1 == false)
            BuyChar1.interactable = true;
        else
            BuyChar1.interactable = false;
        ///////////////
        if (PlayerRef.money >= Char3cost && soldChar3 == false)
            BuyChar3.interactable = true;
        else
            BuyChar3.interactable = false;
    }
    public void Buy_Char1()
    {
        PlayerRef.money -= Char1cost;
        soldChar1 = true;
            BuyChar1Renderer = BuyChar1.GetComponent<Button>();
            BuyChar1Renderer.enabled = false;
            BuyChar1.transform.localPosition = HidePosdetail;
            SelectChar1Renderer = SelectChar1.GetComponent<Button>();
            SelectChar1Renderer.enabled = true;
            SelectChar1.transform.localPosition = ShowPosdetail;
    }
    public void Buy_Char3()
    {
        PlayerRef.money -= Char3cost;
        soldChar3 = true;
        BuyChar3Renderer = BuyChar3.GetComponent<Button>();
        BuyChar3Renderer.enabled = false;
        BuyChar3.transform.localPosition = HidePosdetail;
        SelectChar3Renderer = SelectChar3.GetComponent<Button>();
        SelectChar3Renderer.enabled = true;
        SelectChar3.transform.localPosition = ShowPosdetail;
    }
}
