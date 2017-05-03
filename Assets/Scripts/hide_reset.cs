using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide_reset : MonoBehaviour
{
    public GameObject CB;
    public GameObject RH;
    public GameObject LH;
    public GameObject TE;
    public GameObject OC;
    public GameObject FR;
    public GameObject PA;
    public GameObject ORG;
    public Quaternion originalRotationValue;
    public Button yourButton;
    public float speed = 100F;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;

    // Use this for initialization
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        originalRotationValue = ORG.transform.rotation;
        //Debug.Log(originalRotationValue);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        

        CB.SetActive(true);
        RH.SetActive(true);
        LH.SetActive(true);
        TE.SetActive(true);
        PA.SetActive(true);
        OC.SetActive(true);
        FR.SetActive(true);
        //Debug.Log(originalRotationValue);
        ORG.transform.rotation = Quaternion.Slerp(ORG.transform.rotation, originalRotationValue, Time.time * speed);
        //ORG.transform.rotation = Quaternion.Euler(0,0,0);
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);




    }

}
