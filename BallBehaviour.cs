using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Vector3 oringinalVelocity;
    private Vector3 velocity;
    private Vector3 position;
    public Vector3 gravity;

    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        velocity = oringinalVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        position = position + velocity * Time.deltaTime;
        velocity = velocity + gravity * Time.deltaTime;
        this.transform.position = position;

        if (this.transform.position.y <0.49)
        {
            position.y = 0.52f;

            this.velocity = oringinalVelocity * 0.6f; //the higher this value the higher the ball bounces and the lower the value the lower it bounces
        }

        if (this.transform.position.x >= 19.89) //stops going through right window on the x axis
        {
            velocity.x *= -1f; // speed of bounce back
        }
        if (this.transform.position.x <= -19.97) //stops going through left window on the x axis
        {
            velocity.x *= -1f;
        }
    }
}
