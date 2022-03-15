using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{
    public float speed;
    public float rocketFuel = 100f; // starting fuel count
    public float gravity;
    public Text rocketFuelText; 

    public Rigidbody rocketrigidbody;

    private void Start()
    {
        rocketrigidbody = this.GetComponent<Rigidbody>();
        gravity = -2f; // gravity initially set
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rocketrigidbody.AddForce(new Vector3(0f, speed, 0f)); //set speed on the y axis to go upwards
            rocketFuel -= 0.003f; //how much fuel used when up arrow is pressed
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rocketrigidbody.AddForce(new Vector3(-speed, 0f, 0f) ); // negative speed to move left on the x axis
            rocketFuel -= 0.002f; //how much fuel used when left arrow is pressed
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rocketrigidbody.AddForce(new Vector3(speed, 0f, 0f) ); // positive speed to move right
            rocketFuel -= 0.002f; //how much fuel used when right arrow is pressed
        }
        rocketFuelText.text = "Fuel Remaining: " + rocketFuel.ToString();
        if(rocketFuel<=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
