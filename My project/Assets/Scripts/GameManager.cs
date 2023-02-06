using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    void Awake()
    {
        if (Instance == null)  //if instance has not been set to anything yet
        {
            DontDestroyOnLoad(gameObject); //don't destroy the game manager (?)
            Instance = this; //instance is now called "this"
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
