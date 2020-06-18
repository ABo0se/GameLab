using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class newredbot : MonoBehaviour
{
    [SerializeField] KeyCode RedbotJump;
    [SerializeField] KeyCode RedbotSlide;
    public float redbotjumpSpeed;
    public float redbotslideSpeed;
    Rigidbody2D rb;
    Animator am;
    int redbotjump;
    int redbotslide;

    /// LifeMechanic ////

    public TextMeshProUGUI text3;
    private readonly string Summaryscore = "Summaryscore";
    private readonly string Summarymoney = "Summarymoney";
    int maxlife = 3;
    int life = 3;


    //Use this for initialzation
    void Start()
    {
        redbotjump = 0;
        redbotslide = 0;

        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
        /////////////Life System///////////////
        text3.text = life.ToString();
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(RedbotJump) && redbotjump < 2)
        {
            redbotjump++;
            am.SetBool("redbotjump", true);
            rb.velocity = new Vector2(rb.velocity.x, redbotjumpSpeed);
        }
        else if (Input.GetKey(RedbotSlide) && redbotslide < 1)
        {
            redbotslide++;
            am.SetBool("redbotslide", true);
            rb.velocity = new Vector2(rb.velocity.x, redbotslideSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        redbotjump = 0;
        am.SetBool("redbotjump", false);
    }
    private void OnCollisionStay2D(Collision2D coll)
    {
        redbotslide = 0;
        am.SetBool("redbotslide", false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (life - 1 > 0)
            {
                life--;
                text3.text = life.ToString();
                Destroy(other.gameObject);
            }
            else
            {
                life--;
                text3.text = life.ToString();
                Time.timeScale = 1f;
                Pause.GameIsPaused = false;
                PlayerPrefs.SetInt(Summaryscore, Score.score2);
                PlayerPrefs.SetInt(Summarymoney, MoneyIngame.money);
                SceneManager.LoadScene("ResultScore");
            }
        }
    }
    public void IncreaseLife()
    {
        if (life + 1 > maxlife)
            life = maxlife;
        else
            life++;
    }
}
