using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemonSqueeze : MonoBehaviour
{

	public int squeezeCount;

	public int juicedLemons;

	private float timer;

	public int gameState;

	public Text gameText; 
	
	// Use this for initialization
	void Start ()
	{
		timer = 3;
		gameState = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameState == 1)
		{
			timer -= Time.time;
		} 
		else if (gameState == 0)
		{
			timer = 3;
		}

		gameText.text = (gameState.ToString()); 



		Debug.Log(squeezeCount);
		buttonInputs();
	}

	//registers all of the button inputs
	void buttonInputs()
	{
		if (Input.GetButtonDown("joystick button 1"))
		{
			Debug.Log("x");
			squeezeCount += 1;
		}

		if (Input.GetButtonDown("joystick button 2"))
		{
			Debug.Log("O");
			squeezeCount += 1;
		}

		if (Input.GetButtonDown("joystick button 3"))
		{
			Debug.Log("T");
			squeezeCount += 1;
		}

		if (Input.GetButtonDown( "joystick button 0"))
		{
			Debug.Log("S");
			squeezeCount += 1;
		}
		
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
		
		if (Input.GetButtonDown( "joystick button 8"))
		{
			Debug.Log("Share");
			squeezeCount += 1;
		}
		
		if (Input.GetButtonDown( "joystick button 9"))
		{
			Debug.Log("options");
			squeezeCount += 1;
		}
		if (Input.GetButtonDown( "joystick button 10"))
		{
			Debug.Log("L3");
			squeezeCount += 1;
		}
		
		if (Input.GetButtonDown( "joystick button 11"))
		{
			Debug.Log("R3");
			squeezeCount += 1;
		}
		
		if (Input.GetButtonDown( "joystick button 13"))
		{
			Debug.Log("Touch");
			squeezeCount += 1;
		}
	}
}
