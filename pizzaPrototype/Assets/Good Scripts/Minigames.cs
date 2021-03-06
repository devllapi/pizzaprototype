﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minigames : MonoBehaviour {

    //Variables related to the GameManager
    public int score;

    //Minigame specific variables
    [Header("Sauce Toss")]
    Vector2 lastDirection;
    public float spinsDetected;
    public int quadrant;
    public int fullRotation;
    public bool clockwise;
    private bool[] currentQuandrant = new bool[4];
    private int rotationI;

    [Header("Oregano Stun")] 
    public GameObject oreganoMinigame;
    public OreganoCircle circlesScript;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //Press the shoulder buttons to increase the score
    public void Tenderizer()
    {
        if (Input.GetButtonDown("joystick button 4"))
        {
            score += 1;
        }
        if (Input.GetButtonDown("joystick button 5"))
        {
            score += 1;
        }
    }

    //Rotate the sticks in order to increment the score
    public void SauceToss()
    {
        
        if (rotationI >= 4)
        {
            rotationI = 0;
            fullRotation += 1;
        }
        //check to see if the magnitude of the vector is greater than .2 (if the stick returns to neutral, you fail)

        Vector2 inputDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // GetAxisRaw for more precise reading of analog stick direction
        if (inputDirection.x > 0.2 && inputDirection.y > 0.2)
        {
            quadrant = 0;
            if (currentQuandrant[3] || quadrant == 4)
            {
                rotationI += 1;
                score += 1;
            }
        }
        else if (inputDirection.x > 0.2 && inputDirection.y < 0.2)
        {
            quadrant = 1;
            if (currentQuandrant[0] || quadrant == 4)
            {
                rotationI += 1;
                score += 1;
            }
        }
        else if (inputDirection.x < 0.2 && inputDirection.y < 0.2)
        {
            quadrant = 2;
            if (currentQuandrant[1] || quadrant == 4)
            {
                rotationI += 1;
                score += 1;
            }
        }
        else if (inputDirection.x < 0.2 && inputDirection.y > 0.2)
        {
            quadrant = 3;
            if (currentQuandrant[2] || quadrant == 4)
            {
                rotationI += 1;
                score += 1;
            }
        }

        for (int i = 0; i < currentQuandrant.Length; i++)
        {
            currentQuandrant[i] = false;
        }
        currentQuandrant[quadrant] = true;


        print(inputDirection);                                                                                      // Normalize input only if it exceeds the maximum for either axis alone.
        if (inputDirection.magnitude >= .02)
        {
            quadrant = 4;
        }
    }

    //
    public int OregenoStun()
    {
        oreganoMinigame.gameObject.SetActive(true);
        return score;
    }
}
