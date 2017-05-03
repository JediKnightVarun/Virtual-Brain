using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide_2d : MonoBehaviour {

    public GameObject a = null;
    public GameObject main;
    public GameObject mo;
    public GameObject cc;
    public GameObject pons;
    public Button yourButton;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject all;
    public new AudioSource audio;

    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        main.SetActive(true);
        mo.SetActive(false);
        cc.SetActive(false);
        pons.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
    }
	
	// Update is called once per frame
	void TaskOnClick() {

        main.SetActive(true);
        mo.SetActive(true);
        cc.SetActive(true);
        pons.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);



        if (main != a)
        {
            main.SetActive(false);
        }

        if (mo != a)
        {
            mo.SetActive(false);
        }

        if (cc != a)
        {
            cc.SetActive(false);
        }

        if (pons != a)
        {
            pons.SetActive(false);
        }
        if (all != null)
        {

            if (all != b)

            {
                b.SetActive(false);
            }
            if (all != c)

            {
                c.SetActive(false);
            }
            if (all != d)
            {
                d.SetActive(false);
            }
        }
        else
        {
            d.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);

        }
        if (audio != null)
        {
            audio.Play();
        }

    }
}
