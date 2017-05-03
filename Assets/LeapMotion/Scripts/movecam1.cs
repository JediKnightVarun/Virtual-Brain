using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class movecam1 : MonoBehaviour
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

            finger = hands[0].Fingers[0];
            finger1 = hands[0].Fingers[1];
            float a = hands[0].GrabAngle;
            bool b = finger.IsExtended;
            bool c = finger1.IsExtended;
            
            if (a > 2.0 && b && !c)
            {
                if (hands[0].IsLeft)
                {
                    //Debug.Log("left Thumbs up");

                    transform.Rotate(-Vector3.up * 20* Time.deltaTime);
                }
                else
                {
                    //Debug.Log("Right thumb up");

                    transform.Rotate(Vector3.up * 20 * Time.deltaTime);
                }
            }
            if (a > 2.0 && !b && c)
            {
                if (hands[0].IsLeft)
                {
                    //Debug.Log("left index up");
                   transform.Rotate(Vector3.left, Time.deltaTime * 30);
                }
                else
                {
                    //Debug.Log("Right index up");
                    transform.Rotate(-Vector3.left, Time.deltaTime * 30);
                }

            }
            //Debug.Log(a);
            //Debug.Log(b);
            //Debug.Log(c);


        }



    }
}
