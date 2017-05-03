using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject target = null;
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
        if (target != null)
        {
            
            if (Input.GetKey("down"))
                transform.Rotate(Vector3.down * 20 * Time.deltaTime);
            if (Input.GetKey("up"))
                transform.Rotate(Vector3.up * 20 * Time.deltaTime);
            if (Input.GetKey("left"))
                transform.Rotate(Vector3.left * 20 * Time.deltaTime);
            if (Input.GetKey("right"))
                transform.Rotate(Vector3.right * 20 * Time.deltaTime);
        }

	}
}
