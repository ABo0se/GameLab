using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        if (gameObject.name == "Money")
            text.text = PlayerRef.money.ToString();
    }
}
