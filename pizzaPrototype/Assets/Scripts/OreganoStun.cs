using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class OreganoStun : MonoBehaviour
{
	
	public float maxTime = 100f;
	public float curTime = 0f;

	
	
	private bool buttonOneActive;
	private bool buttonOneDead;
	private bool buttonOneResult;
	
	private bool buttonTwoActive;
	private bool buttonTwoDead;
	private bool buttonTwoResult;

	private bool buttonThreeActive;
	private bool buttonThreeDead;
	private bool buttonThreeResult;

	public Image Bar;

	// Use this for initialization
	void Start ()
	{
		//Time.timeScale = .1f; 
		curTime = 0f; 
		//at the start of script, 
		InvokeRepeating("increaseTime", 0f, 0.03f);
	}
	
	// Update is called once per frame
	void Update () {
		//the amount of time it takes for the bar to reach the first button
		if (curTime >= 27f)
		{
			buttonOneActive = true;
			Debug.Log(buttonOneActive);
		} else if (curTime <= 44f)
		{
			buttonOneActive = false;
			Debug.Log(buttonOneActive);
		}

		if (buttonOneActive == true)
		{
			if (Input.GetButtonDown("joystick button 1"))
			{
				buttonOneResult = true;
				Debug.Log("success");
			}
			else
			{
				buttonOneResult = false;
				Debug.Log("fail");
			}
		}

	}

	void increaseTime()
	{
		curTime += 1f;
		// The bar's fill amount is locked to 0-1, so we need to set its fill amount to a fraction
		float calcTime = curTime / maxTime;
		setPress(calcTime);
	}

	void setPress(float theTime)
	{
		Bar.fillAmount = theTime;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "oCircle")
		{
			//buttonActive = true;
			Debug.Log("active");
		}
	}
}
