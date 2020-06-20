using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class newopp : MonoBehaviour
{
    [SerializeField] KeyCode oppJump;
    [SerializeField] KeyCode oppSlide;
    public float oppjumpSpeed;
    public float oppslideSpeed;

    Rigidbody2D rb;
    Animator am;
    int oppjump;
    int oppslide;
    /// LifeMechanic ////

    public TextMeshProUGUI text4;
    private readonly string Summaryscore = "Summaryscore";
    private readonly string Summarymoney = "Summarymoney";
    int maxlife = 2;
    int life = 2;
    public bool indestructable = false;
    public bool bigpowerupstate = false;
    public GameObject ObjectChar1;

    //Use this for initialzation
    void Start()
    {
        oppjump = 0;
        oppslide = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
        /////////////Life System///////////////
        text4.text = life.ToString();
    }
    //Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(10f, 0, 0) * Time.deltaTime;
        if (Input.GetKeyDown(oppJump) && oppjump < 3)
        {
            oppjump++;
            am.SetBool("oppjump", true);
            rb.velocity = new Vector2(rb.velocity.x, oppjumpSpeed);
        }
        else if (Input.GetKey(oppSlide) && oppslide < 1)
        {
            oppslide++;
            am.SetBool("oppslide", true);
            rb.velocity = new Vector2(rb.velocity.x, oppslideSpeed);

        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        oppjump = 0;
        am.SetBool("oppjump", false);

    }
    private void OnCollisionStay2D(Collision2D coll)
    {
        oppslide = 0;
        am.SetBool("oppslide", false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
            if (indestructable == false)
            {
                if (life - 1 > 0)
                {
                    life--;
                    text4.text = life.ToString();
                }
                else
                {
                    life--;
                    text4.text = life.ToString();
                    Time.timeScale = 1f;
                    PlayerPrefs.SetFloat("Timescale", 1f);
                    Pause.GameIsPaused = false;
                    PlayerPrefs.SetInt(Summaryscore, Score.score2);
                    PlayerPrefs.SetInt(Summarymoney, MoneyIngame.money);
                    SceneManager.LoadScene("ResultScore");
                }
            }
            else
            {

            }
        }
        if (other.gameObject.CompareTag("Life"))
        {
            Destroy(other.gameObject);
            IncreaseLife();

        }
    }
    public void IncreaseLife()
    {
        if (life + 1 > maxlife)
            life = maxlife;
        else
        {
            life++;
            text4.text = life.ToString();
        }
    }
    public Vector3 GetPosition1()
    {
        if (ObjectChar1 == null)
            ObjectChar1 = GameObject.FindGameObjectWithTag("Player");
        Vector3 Playerposition;
        Playerposition = ObjectChar1.transform.position;
        return Playerposition;
    }
}
