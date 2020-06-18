using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class newgirl : MonoBehaviour
{
    [SerializeField] KeyCode Jump;
    [SerializeField] KeyCode Slide;
    public float jumpSpeed;
    public float slideSpeed;
    Rigidbody2D rb;
    Animator am;
    int jump;
    int slide;
    /// LifeMechanic ////

    public TextMeshProUGUI text5;
    private readonly string Summaryscore = "Summaryscore";
    private readonly string Summarymoney = "Summarymoney";
    int maxlife = 2;
    int life = 2;

    //Use this for initialzation
    void Start()
    {
        jump = 0;
        slide = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
        /////////////Life System///////////////
        text5.text = life.ToString();
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Jump) && jump < 2)
        {
            jump++;
            am.SetBool("Jump", true);
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        else if  (Input.GetKey(Slide) && slide < 1)
        {
            slide++;
            am.SetBool("Slide", true);
            rb.velocity = new Vector2(rb.velocity.x,slideSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        jump = 0;
        am.SetBool("Jump", false);
    }
    private void OnCollisionStay2D(Collision2D coll)
    {
        slide = 0;
        am.SetBool("Slide", false);
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
                text5.text = life.ToString();
                Destroy(other.gameObject);
            }
            else
            {
                life--;
                text5.text = life.ToString();
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
    


