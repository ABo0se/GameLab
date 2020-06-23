using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollItemandObstacle : MonoBehaviour
{
    public float bgSpeed;
    float bgPositionX;

    void Start()
    {
        bgPositionX = transform.position.x;
    }

    void Update()
    {
        if (Time.deltaTime != 0)
        transform.position = new Vector3(transform.position.x + bgSpeed, transform.position.y, transform.position.z);
    }
}
