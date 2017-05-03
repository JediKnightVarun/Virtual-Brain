using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideallimages : MonoBehaviour {
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public AudioSource a2, a1;

    // Use this for initialization
    void Start () {
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);
        a1.Play();
        a2.PlayDelayed(10);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
