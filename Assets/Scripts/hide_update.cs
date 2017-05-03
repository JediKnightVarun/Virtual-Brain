using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide_update : MonoBehaviour {
    public GameObject a,b,c,d,e,f = null;
    public GameObject CB;
    public GameObject RH;
    public GameObject LH;
    public GameObject TE;
    public GameObject OC;
    public GameObject FR;
    public GameObject PA;
     public Button yourButton;
    public AudioSource audio;
    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }

    // Update is called once per frame
    void TaskOnClick() {

        CB.SetActive(true);
        RH.SetActive(true);
        LH.SetActive(true);
        TE.SetActive(true);
        PA.SetActive(true);
        OC.SetActive(true);
        FR.SetActive(true);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);
        f.SetActive(false);




        if (CB != a)
        {
            CB.SetActive(false);
        }
        if (RH != a)
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
        if (CB == a)
        {
            f.SetActive(true);
        }
        if (TE == a)
        {
            b.SetActive(true);
        }
        if (PA == a )
            {
            d.SetActive(true);
        }
        if (OC == a)
        {
            c.SetActive(true);
        }
        if (FR ==a )
        {
            e.SetActive(true);
        }
        audio.Play();
        
    }
  
}
