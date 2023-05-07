using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class gui : MonoBehaviour
{
    public int playerWin;
    public int aIWin;
    public GameObject wins;
    private ballMovement ballMovement;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        ballMovement = wins.GetComponent<ballMovement>();
        playerWin = ballMovement.playerWins;
        aIWin = ballMovement.AIWins;
        TextMeshProUGUI mText = gameObject.GetComponent<TextMeshProUGUI>();
        mText.text = Convert.ToString(aIWin);
    }
}
