using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMany : MonoBehaviour
{

    public GameObject enemy;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float random = Random.Range(-50f, 50f);

        for (int i = 0; i < 20; i++)
        {
            Instantiate(enemy, new Vector3(random, random + 10, 0), Quaternion.identity);
        }
	}
}
