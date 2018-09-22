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
			timer = 3f;
		}

		theTime.text = timer.ToString();
        if (timer <= 0f)
        {
            timer = 0f;
            gameState = 0;
        }
		//gameText.text = (gameState.ToString()); 



		Debug.Log(squeezeCount);
		buttonInputs();
	}

	//registers all of the button inputs
	void buttonInputs()
	{
		
		
		if (Input.GetButtonDown( "joystick button 4"))
		{
			Debug.Log("L1");
			squeezeCount += 1;
		}
		
		if (Input.GetButtonDown( "joystick button 5"))
		{
			Debug.Log("R1");
			squeezeCount += 1;
		}
		
		if (Input.GetButtonDown( "joystick button 6"))
		{
			Debug.Log("L2");
			squeezeCount += 1;
		}
		
		if (Input.GetButtonDown( "joystick button 7"))
		{
			Debug.Log("R2");
			squeezeCount += 1;
		}
		
	
	}
}
