using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opacity : MonoBehaviour {

	// Use this for initialization
	void Start () {

        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
