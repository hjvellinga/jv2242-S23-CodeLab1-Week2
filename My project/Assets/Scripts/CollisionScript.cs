using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    //public int currentLevel = 0; -> should be in game manager
    // Start is called before the first frame update
    
    //declare variable original position player 1
    public Vector2 originalPosPl1;
    //declare game object player 2?
    public GameObject Player2;
    //declare variable original position player 2
    public Vector2 originalPosPl2; 
    void Start()
    {
        //set Player2
        Player2 = GameObject.Find("Player2"); //find the game object named "player2" in the scene ASK SOMEONE FOR HELP!!
        //set originalPos player1 & player 2

        originalPosPl1 = gameObject.transform.position;
        originalPosPl2 = Player2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player2")
            
        {
            //BUT ONLY ON COLLISION?!?
            //GetComponent <ParticleSystem>().Play ();
            //ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
            //em.enabled = true;
            //
            
            SceneManager.LoadScene("Level2");
            gameObject.transform.position = originalPosPl1; //reset position Player 1.
           
            
            
        }
    }
}
