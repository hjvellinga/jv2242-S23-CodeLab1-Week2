using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float forceAmount = 10; 
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frames
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right*forceAmount);
        }
        rb2d.velocity *= 0.999f;
    }
}
