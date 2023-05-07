using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballMovement : MonoBehaviour
{
    public int speed;
    public int playerWins;
    public int AIWins;
    public Vector2 ballPosition;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        StartBall();  
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("BounceVertical"))
        {
            ballPosition.y = ballPosition.y * -1;
            
        }
        if (other.gameObject.CompareTag("BounceHorizontal"))
        {
            
            ballPosition.x = ballPosition.x * -1;
        }
        if (other.gameObject.CompareTag("PlayerGoal"))
        {
            StartBall();
            Debug.Log("Goal");
            AIWins++;
        }
        if (other.gameObject.CompareTag("KIGoal"))
        {
            StartBall();
            Debug.Log("Goal");
            playerWins++;
            
        }

        if (speed < 20)
        {
            speed++;
        }

    }

    public void StartBall()
    {

        speed = 5;
        ballPosition = Vector2.zero;
        transform.position = (ballPosition);
        new WaitForSecondsRealtime(3);
        while (ballPosition.x < 0.3 && ballPosition.x > -0.3)
        {
            ballPosition = new Vector2(Random.value, Random.value);
        }
        ballPosition.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        
        ballPosition.Normalize();

        transform.Translate(ballPosition * Time.deltaTime * speed);

    }
}
