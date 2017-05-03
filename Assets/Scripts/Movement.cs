using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float mSpeed;
	void Start ()
    {
		mSpeed = 7f;
	}
	
	void Update ()
    {
        transform.Translate (mSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);

        
        if (Input.GetKey("down"))
        transform.Translate(Vector3.up);
        if (Input.GetKey("up"))
        transform.Translate(Vector3.down);
        

    }
}
