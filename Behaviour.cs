using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{

    public float speed; //speed of the player when travelling to the waypoints
    public Transform[] wpArray;

    int i = 0;
    Vector3 spherePos; //player position
    Vector3 direction; 
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        spherePos = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            spherePos = this.transform.position;
            direction = wpArray[i].position - spherePos;
            direction = direction.normalized;
            velocity = direction * speed;
            this.transform.position = this.transform.position + velocity * Time.deltaTime;
            if (Vector3.Distance(this.transform.position, wpArray[i].position)<0.1f)
            {
                i++;
                if(i>=4) //keeps track of each waypoint met
                {
                i = 0;
                }
            }
    }
}
