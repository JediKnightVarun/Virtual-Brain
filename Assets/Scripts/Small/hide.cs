using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour {
    public GameObject a = null;
    public GameObject CB = null;
    public GameObject RH = null;
    public GameObject LH = null;
    public GameObject TE = null;
    public GameObject OC = null;
    public GameObject FR = null;
    public GameObject PA = null;
    // Use this for initialization
    void Start () {
       
      


    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0))
        {
            if (CB != a)
            {
                CB.SetActive(false);
            }
            if (RH!= a)
            {
                RH.SetActive(false);
            }
            if (LH != a)
            {
                LH.SetActive(false);
            }
            if (TE != a)
            {
                TE.SetActive(false);
            }
            if (OC != a)
            {
                OC.SetActive(false);
            }
            if (FR != a)
            {
                FR.SetActive(false);
            }
            if (PA != a)
            {
                PA.SetActive(false);
            }
        }
    }
}
