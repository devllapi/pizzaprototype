﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour {
    public Text combatText;
    public LemonSqueezeMinigame squeezeScript;
    public potSpinning stirSauce;

    public Button button1;
    public Button button2;
    public Button button3;

    public float enemyHealthFloat;
    public Text enemyHealth;

    public Text rotationCountText;
    public Text timerText;

    public Text squeezeCountText;
    
    // Use this for initialization
    void Start () {
        enemyHealthFloat = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        enemyHealth.text = enemyHealthFloat.ToString();
        if (squeezeScript.gameState == 1)
        {
            timerText.text = squeezeScript.timer.ToString() ;
        }
        if (stirSauce.gameState == 1)
        {
            timerText.text = stirSauce.timer.ToString();
        }
        if (squeezeScript.gameState == 0)
        {
            
            if(squeezeScript.squeezeCount>25 && squeezeScript.squeezeCount < 50)
            {
                enemyHealthFloat -= 20f;
                combatText.text = "A zesty strike!";
            }
            else if (squeezeScript.squeezeCount > 40)
            {
                enemyHealthFloat -= 40f;
                combatText.text = "Wow! They must be feeling pretty sour right now!";
            }
            squeezeScript.squeezeCount = 0;
        }
        if (stirSauce.gameState == 0)
        {

            if (stirSauce.fullRotation > 10 && stirSauce.fullRotation < 15)
            {
                enemyHealthFloat -= 20f;
                combatText.text = "A zesty strike!";
            }
            else if (stirSauce.fullRotation > 10)
            {
                enemyHealthFloat -= 40f;
                combatText.text = "Wow! They must be feeling pretty sour right now!";
            }
            stirSauce.fullRotation = 0;
        }
    }

    public void LemonSqueeze()
    {
        combatText.text= "MASH BUTTONS AND SQUEEZE LEMONS";
        squeezeScript.gameState = 1;

        
        //timer counts down from 5 seconds, then player can select next spell
    }
    public void OreganoOreganized()
    {
        combatText.text = "Spell not learned!";
        //button2.interactable=false;
    }
    public void PotSpin()
    {
        combatText.text = "STIR THAT SAUCE";
        stirSauce.gameState = 1;

      
    }
}
