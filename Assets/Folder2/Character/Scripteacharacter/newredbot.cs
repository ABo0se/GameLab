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
    public bool indestructable = false;
    public bool bigpowerupstate = false;
    public bool Dead = false;
    public GameObject ObjectChar3;


    //Use this for initialzation
    void Start()
    {
        bigpowerupstate = false;
        Dead = false;
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
        if (Dead == false)
            transform.position += new Vector3(10f, 0, 0) * Time.deltaTime;

        if (Input.GetKeyDown(RedbotJump) && redbotjump < 2 && Dead == false)
        {
            redbotjump++;
            am.SetBool("redbotjump", true);
            GetComponent<AudioSource>().Play();
            rb.velocity = new Vector2(rb.velocity.x, redbotjumpSpeed);
        }
        else if (Input.GetKey(RedbotSlide) && redbotslide < 1 && Dead == false)
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
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (indestructable == false)
            {
                if (life - 1 > 0)
                {
                    life--;
                    text3.text = life.ToString();
                }
                else
                {
                    Dead = true;
                    life--;
                    text3.text = life.ToString();
                    am.SetBool("redbotdead", true);
                    Time.timeScale = 1f;
                    PlayerPrefs.SetFloat("Timescale", 1f);
                    StartCoroutine(SmoothAnimation3());
                }
            }
        }
        if (other.gameObject.CompareTag("Life"))
        {
            IncreaseLife();
        }
    }
    IEnumerator SmoothAnimation3()
    {
        yield return new WaitForSeconds(1.0f);
        Pause.GameIsPaused = false;
        PlayerPrefs.SetInt(Summaryscore, Score.score2);
        PlayerPrefs.SetInt(Summarymoney, MoneyIngame.money);
        SceneManager.LoadScene("ResultScore");
    }
    public void IncreaseLife()
    {
        if (life + 1 > maxlife)
        {
            life = maxlife;
            text3.text = life.ToString();
        }
        else
        {
            life++;
            text3.text = life.ToString();
        }
    }
    public Vector3 GetPosition3()
    {
        if (ObjectChar3 == null)
            ObjectChar3 = GameObject.FindGameObjectWithTag("Player");
        Vector3 Playerposition;
        Playerposition = ObjectChar3.transform.position;
        return Playerposition;
    }
}
