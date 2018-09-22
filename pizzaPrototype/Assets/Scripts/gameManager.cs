using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour {
    public Text combatText;
    public LemonSqueezeMinigame squeezeScript;

    public Button button1;
    public Button button2;
    public Button button3;
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
        combatText.text = "Spell not learned!";
        button2.interactable=false;
    }
    public void OreganoOreganized()
    {
        combatText.text = "Spell not learned!";
        button3.interactable = false;
    }
}
