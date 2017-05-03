using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class plottip : MonoBehaviour
{
    Leap.Controller controller;
    public Frame frame;
    public Hand firsthand;
    Finger finger, finger1;
    public GameObject cube;


    // Use this for initialization
    void Start()
    {
        controller = new Leap.Controller();


    }

    // Update is called once per frame
    void Update()
    {

        frame = controller.Frame();
        if (frame.Hands.Count > 0)
        {
            List<Hand> hands = frame.Hands;

            finger = hands[0].Fingers[1];
            
      Debug.Log(finger.TipPosition);

            


        }
    }
}
