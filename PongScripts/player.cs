using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 4f;

  





    void Update()
    {

        
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            move = Vector3.up;
        }
      
        if (Input.GetKey(KeyCode.S))
        {
            move = Vector3.down;
        }

        transform.Translate(move * Time.deltaTime * speed);
    }
}
