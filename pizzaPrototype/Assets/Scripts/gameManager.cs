using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class gameManager : MonoBehaviour {
    public Text combatText;
    public LemonSqueezeMinigame squeezeScript;
    public potSpinning stirSauce;
    public OreganoCircle oCircles;
    public OreganoStun oBar;

    public Button button1;
    public Button button2;
    public Button button3;

    public float enemyHealthFloat;
    public Text enemyHealth;

  
    public Text rotationCountText;
    public Text timerText;

    public Text squeezeCountText;
    public Text spinCountText;
   
    // Use this for initialization
    void Start () {
        enemyHealthFloat = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        enemyHealth.text = "Enemy Health:"+enemyHealthFloat.ToString();

        squeezeCountText.text = "Meat Spell Strength:" + squeezeScript.squeezeCount.ToString();
        spinCountText.text = "Sauce Spell Strength:" + stirSauce.fullRotation.ToString();

        if (squeezeScript.gameState == 1 && stirSauce.gameState==0)
        {
            timerText.text = squeezeScript.timer.ToString();
        }
        if (stirSauce.gameState == 1 && squeezeScript.gameState==0)
        {
            timerText.text = stirSauce.timer.ToString();
        }
        if (squeezeScript.timer <= 0)
        {
            timerText.text = "0.0";
        }
        if (stirSauce.timer <= 0)
        {
            timerText.text = "0.0";
        }
        if (squeezeScript.gameState == 0)
        {

            if (squeezeScript.squeezeCount>20 && squeezeScript.squeezeCount < 30)
            {
                enemyHealthFloat -= 20f;
                combatText.text = "A beefy strike!";
            }
            else if (squeezeScript.squeezeCount > 30)
            {
                enemyHealthFloat -= 40f;
                combatText.text = "Wow! Well done! Get it? Like...doneness...meat...";
            }else if (squeezeScript.squeezeCount < 25 && squeezeScript.squeezeCount > 0)
                {
                    enemyHealthFloat -= 10f;
                    combatText.text = "Who are you going to beat if you can't ball some meat?";
                }
            squeezeScript.squeezeCount = 0;
        }
        if (stirSauce.gameState == 0)
        {

            if (stirSauce.fullRotation > 10 && stirSauce.fullRotation < 15)
            {
                enemyHealthFloat -= 20f;
                combatText.text = "A meaty strike!";
            }
            else if (stirSauce.fullRotation > 15)
            {
                enemyHealthFloat -= 40f;
                combatText.text = "Wow! They must be feeling pretty sour right now!";
            }
            else if(stirSauce.fullRotation<10 && stirSauce.fullRotation > 0)
            {
                enemyHealthFloat -= 10f;
                combatText.text = "Yikes, I think you may have gotten lost in the sauce.";
            }
            stirSauce.fullRotation = 0;
        }
    }

    public void LemonSqueeze()
    {
        combatText.text = "MASH BUTTONS TO POUND MEAT!";
        squeezeScript.gameState = 1;
        
        //timer counts down from 5 seconds, then player can select next spell
    }
    public void OreganoButtonPress()
    {
        oCircles.gameState = 1;
        oBar.gameState = 1;
    }
    
    public void PotSpin()
    {
        combatText.text = "STIR THAT SAUCE";
        stirSauce.gameState = 1;
      
    }
}

