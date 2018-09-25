using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemonSqueezeMinigame : MonoBehaviour
{

	public int squeezeCount;

	public int juicedLemons;

	private float timer;

	public int gameState;

	public Text gameText;

	public Text theTime;

    private bool R1P;
    private bool R2P;
    private bool L1P;
    private bool L2P;

    public Text squeezedText;
    // Use this for initialization
    void Start ()
	{
		timer = 3;
		gameState = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameState == 1)
		{
			timer -= Time.deltaTime;
		} 
		else if (gameState == 0)
		{
			timer = 5f;
            squeezeCount = 0;
           
		}

		theTime.text = timer.ToString();
        if (timer <= 0f)
        {
            timer = 0f;
            gameState = 0;
        }
        //gameText.text = (gameState.ToString()); 



        squeezedText.text = "Lemons Squeezed:" + squeezeCount.ToString();

		buttonInputs();
	}

	//registers all of the button inputs
	void buttonInputs()
    {
        //ensure code is only active when the lemon squeeze attack is selected.
        if (gameState == 1)
        {
            //checks to see which of the shoulder buttons have been pressed.
            if (Input.GetButtonDown("joystick button 4"))
            {
                L1P = true;
            }
            if (Input.GetButtonDown("joystick button 5"))
            {
                R1P = true;
            }
            if (Input.GetButtonDown("joystick button 6"))
            {
                L2P = true;
            }
            if (Input.GetButtonDown("joystick button 7"))
            {
                R2P = true;
            }

            if (L1P == true && R1P == true && L2P == true && R2P == true)
            {
                squeezeCount += 1;
                L1P = false;
                R1P = false;
                L2P = false;
                R2P = false;
            }

        }

    }
}
