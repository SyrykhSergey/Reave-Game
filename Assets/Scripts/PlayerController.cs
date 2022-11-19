using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public float speed;
    public float horizontalSpeed;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();   
    }

    public void LeftButtonDown()
    {
        speed = -horizontalSpeed;
    }

    public void RightButtonDown()
    {
        speed = horizontalSpeed;
    }
    public void Stop()
    {
        speed = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(speed, 0);
    }
}
