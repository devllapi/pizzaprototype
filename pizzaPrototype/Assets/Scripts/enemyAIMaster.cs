using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemyAIMaster : MonoBehaviour {
    public int enemyHealth;
    int whoseTurn;

    public enemy[] enemyList;
    public int playerSelect;
    public GameObject enemyPrefab;

    // Use this for initialization
    void Start () {

        generateEnemies(1, 3);

        enemyList[playerSelect].health -= 40;
        if(playerSelect >= enemyList.Length)
        {
            playerSelect = 0;
        }else if (playerSelect < 0)
        {
            playerSelect = enemyList.Length - 1;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (whoseTurn == 0)
        {
            //players turn
        }
        if (whoseTurn == 1)
        {
            //enemies turn
            for (int i = 0; i < enemyList.Length; i++)
            {
                if(Random.Range(0,1) > 0.5f)
                {
                    enemyList[i].attack();
                }
                else
                {
                    enemyList[i].defend();
                }
               
            }
        }
        
	}

    

    //This function will generate a series of random enemies (according to params)
    //and set them to the EnemyList
    public void generateEnemies(int min, int max)
    {
        //Determines the Length of the List
        int num = (int)Random.Range(min, max);
        enemyList = new enemy[num];

        //Spawns list.length number of enemies
        for(int i = 0; i < num; i++)
        {
            //Grabs relevant component of Chef
            enemyList[i] = Instantiate(enemyPrefab, this.gameObject.transform).GetComponent<enemyChef>();

            //Sets enemy instance to be child of this object
            enemyList[i].gameObject.transform.SetParent(gameObject.transform, true);
        }
    }
}
