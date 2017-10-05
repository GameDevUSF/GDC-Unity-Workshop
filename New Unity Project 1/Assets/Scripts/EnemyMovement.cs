using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed;

    public GameObject player;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 distance = player.transform.position - gameObject.transform.position;

        if (Vector3.Magnitude(distance) > -5 && Vector3.Magnitude(distance) < 5)
        {
            transform.position += Vector3.Normalize(distance) * speed * Time.deltaTime;
        }



	}
}
