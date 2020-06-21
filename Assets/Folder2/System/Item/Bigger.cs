using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bigger : MonoBehaviour
{
    int pawerupboost;
    public GameObject BigBoost;
    float duration;
    int Characteruse4;
    private readonly string Timeboost = "Timeboost";
    private readonly string SelectedCharacter = "SelectedCharacter";

    private void Awake()
    {
        Characteruse4 = PlayerPrefs.GetInt(SelectedCharacter);
        pawerupboost = PlayerPrefs.GetInt(Timeboost);
        switch (pawerupboost)
        {
            case 0:
                duration = 4.0f;
                break;
            case 1:
                duration = 5.0f;
                break;
            default:
                duration = 4.0f;
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }
    IEnumerator Pickup(Collider2D other)
    {
        newgirl big = other.GetComponent<newgirl>();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        switch (Characteruse4)
        {
            case 1:
                newopp opp = other.GetComponent<newopp>();
                if (opp.bigpowerupstate == false)
                {
                    AudioSource audio = GetComponent<AudioSource>();
                    audio.Play();
                    opp.bigpowerupstate = true;
                    opp.indestructable = true;
                    other.transform.localScale *= 2;
                    yield return new WaitForSecondsRealtime(duration);
                    opp.bigpowerupstate = false;
                    opp.indestructable = false;
                    other.transform.localScale /= 2;
                    Destroy(BigBoost);
                }
                break;
            case 2:
                if (big.bigpowerupstate == false)
                {
                    AudioSource audio = GetComponent<AudioSource>();
                    audio.Play();
                    big.bigpowerupstate = true;
                    big.indestructable = true;
                    other.transform.localScale *= 2;
                    yield return new WaitForSecondsRealtime(duration);
                    big.bigpowerupstate = false;
                    big.indestructable = false;
                    other.transform.localScale /= 2;
                    Destroy(BigBoost);
                }
                    break;
            case 3:
                newredbot redbot = other.GetComponent<newredbot>();
                if (redbot.bigpowerupstate == false)
                {
                    AudioSource audio = GetComponent<AudioSource>();
                    audio.Play();
                    redbot.bigpowerupstate = true;
                    redbot.indestructable = true;
                    other.transform.localScale *= 2;
                    yield return new WaitForSecondsRealtime(duration);
                    redbot.bigpowerupstate = false;
                    redbot.indestructable = false;
                    other.transform.localScale /= 2;
                    Destroy(BigBoost);
                }
                break;
            default:
                if (big.bigpowerupstate == false)
                {
                    AudioSource audio = GetComponent<AudioSource>();
                    audio.Play();
                    big.bigpowerupstate = true;
                    big.indestructable = true;
                    other.transform.localScale *= 2;
                    yield return new WaitForSecondsRealtime(duration);
                    big.bigpowerupstate = false;
                    big.indestructable = false;
                    other.transform.localScale /= 2;
                    Destroy(BigBoost);
                }
                break;
        }
    }
}
