using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadSpinning : MonoBehaviour {
    Vector2 lastDirection;
    public float oppositeThreshhold = -0.9f; // How precisely does the analog stick have to be pressed in the opposite direction it was previously?
                                             // ...

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // ...
        Vector2 inputDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // GetAxisRaw for more precise reading of analog stick direction
                                                                                                            // Normalize input only if it exceeds the maximum for either axis alone.
        if (inputDirection.sqrMagnitude > 1)
        {
            inputDirection = inputDirection.normalized;
        }
        if (inputDirection.sqrMagnitude > 0.95f)
        {
            if (Vector2.Dot(inputDirection, lastDirection) < oppositeThreshhold)
            {
                // Opposite Direction
            }
            lastDirection = inputDirection;
        }
}
