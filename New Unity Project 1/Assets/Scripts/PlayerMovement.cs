using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    private float fullhealth = 100;

    //AudioSource sound;

    // Use this for initialization
    void Start ()
    {
        //sound = gameObject.GetComponent<AudioSource>();		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


       transform.position += transform.forward * speed * v * Time.deltaTime;
       transform.position += transform.right * speed * h * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            fullhealth -= 10;
            Destroy(gameObject);
            //sound.PlayOneShot();
        }
    }
}
