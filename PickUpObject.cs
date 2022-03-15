using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Rigidbody rb;
    public HingeJoint hj;
    int boulderCounter;

    private void Start()
    {
        hj = GetComponent<HingeJoint>();
        boulderCounter = 0; //initial count 
    }

    private void Update()
    {
        if(boulderCounter >= 3) //keeps track of how many boulders are in the dropzone
        {
            Debug.Log("Complete.");
            Application.Quit(); //quits game once all boulders are moved to the destination
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ropeEnd") // the end of the rope that connects to the boulders
        {
            hj.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerEnter(Collider other) //ending container accepting the boulders
    {
        if (other.tag == "dropZone")
        {
            hj.connectedBody = null; //being able to detach
            boulderCounter++; //adds boulder to dropzone 
        }
    }
}
