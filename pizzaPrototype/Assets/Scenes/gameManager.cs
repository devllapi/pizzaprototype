using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour {
    public Text combatText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LemonSqueeze()
    {
        combatText.text= "Lemon Button Pressed";
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
