using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    //public int currentLevel = 0; -> should be in game manager
    // Start is called before the first frame update
    
    //declare variable original position
    public Vector2 originalPosPl1; 
    void Start()
    {
        //set originalPos player

        originalPosPl1 = gameObject.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player2")
        {
            SceneManager.LoadScene("Level2");
            gameObject.transform.position = originalPosPl1; //reset position Player 1.
            //REPEAT FOR PLAYER 2!!!
        }
    }
}
