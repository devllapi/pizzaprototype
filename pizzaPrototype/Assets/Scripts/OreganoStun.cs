using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class OreganoStun : MonoBehaviour
{
	
	public float maxTime = 100f;
	public float curTime = 0f;


	public Image Bar;

	// Use this for initialization
	void Start ()
	{
		curTime = 0f; 
		//at the start of script, 
		InvokeRepeating("increaseTime", 0f, 0.03f);
	}
	
	// Update is called once per frame
	void Update () {

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

}
