using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KIMovement : MonoBehaviour
{
    public float speed = 4f;
    Vector2 ballPos;
    public GameObject ball;
    private ballMovement ballMovement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ballMovement = ball.GetComponent<ballMovement>();
        ballPos = ballMovement.transform.position - transform.position;
        ballPos.x = 0;
        ballPos.Normalize();
        transform.Translate(ballPos * Time.deltaTime * speed);


    }
}
