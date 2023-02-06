using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private Rigidbody2D rb2d2; //declare rigidbody2d variable + give name

    public float forceAmount2 = 10; //declare forceAmount variable
    // Start is called before the first frame update
    void Start()
    {
        rb2d2 = GetComponent<Rigidbody2D>(); //determine content of rb2d2
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb2d2.AddForce(Vector2.left*forceAmount2);
        }
        rb2d2.velocity *= 0.999f;
    }
}
