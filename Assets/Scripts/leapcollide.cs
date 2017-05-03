using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
public class leapcollide : MonoBehaviour
{
    Leap.Controller controller;
    public Frame frame;
    public Hand firsthand;
    Finger finger, finger1;
   // public GameObject cube;


    // Use this for initialization
    void Start()
    {
        controller = new Leap.Controller();


    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hint");
    }

}
