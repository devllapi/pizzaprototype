using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour {
    public Text combatText;
    public LemonSqueezeMinigame squeezeScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LemonSqueeze()
    {
        combatText.text= "MASH BUTTONS AND SQUEEZE LEMONS";
        squeezeScript.gameState = 1;
        //timer counts down from 3 seconds, then player can select next spell
    }
    public void BreadBash()
    {
        combatText.text = "Bread Button Pressed";
    }
    public void OreganoOreganized()
    {
        combatText.text = "Oregano Button Pressed";
    }
}
