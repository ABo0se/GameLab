﻿using System.Collections;
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
    public GameObject ObjectChar2;
    /// LifeMechanic ////

    public TextMeshProUGUI text5;
    private readonly string Summaryscore = "Summaryscore";
    private readonly string Summarymoney = "Summarymoney";
    int maxlife = 2;
    int life = 2;
    public bool indestructable = false;
    public bool bigpowerupstate = false;
    public bool Dead = false;
    /// Audio
    //Use this for initialzation
    void Start()
    {
        indestructable = false;
        bigpowerupstate = false;
        jump = 0;
        slide = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
        /////////////Life System///////////////
        text5.text = life.ToString();
        Dead = false;
        /////////////Sound
    }
    //Update is called once per frame
    void Update()
    {
        if (Dead == false)
        transform.position += new Vector3(10f, 0, 0) * Time.deltaTime;

        if (Input.GetKeyDown(Jump) && jump < 2 && Dead == false)
        {
            jump++;
            am.SetBool("Jump", true);
            GetComponent<AudioSource>().Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        else if  (Input.GetKey(Slide) && slide < 1 && Dead == false)
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
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (indestructable == false)
            {
                ObjectChar2.GetComponent<Animation>().Play("hurtchar2");
                if (life - 1 > 0)
                {
                    life--;
                    text5.text = life.ToString();
                }
                else
                {
                    Dead = true;
                    life--;
                    text5.text = life.ToString();
                    am.SetBool("dead", true);
                    Time.timeScale = 1f;
                    PlayerPrefs.SetFloat("Timescale", 1f);
                    StartCoroutine(SmoothAnimation2());
                }
            }
            else
            {
            }
        }
        if (other.gameObject.CompareTag("Life"))
        {
            IncreaseLife();
        }
    }
    IEnumerator SmoothAnimation2()
    {
        yield return new WaitForSeconds(2.0f);
        Pause.GameIsPaused = false;
        PlayerPrefs.SetInt(Summaryscore, Score.score2);
        PlayerPrefs.SetInt(Summarymoney, MoneyIngame.money);
        SceneManager.LoadScene("ResultScore");
    }    
    public Vector3 GetPosition2()
    {
       if (ObjectChar2 == null)
           ObjectChar2 = GameObject.FindGameObjectWithTag("Player");
        Vector3 Playerposition;
        Playerposition = ObjectChar2.transform.position;
        return Playerposition;
    }
    public void IncreaseLife()
    {
        if (life + 1 > maxlife)
        {
            life = maxlife;
            text5.text = life.ToString();
        }
        else
        {
            life++;
            text5.text = life.ToString();
        }
    }
}
    


