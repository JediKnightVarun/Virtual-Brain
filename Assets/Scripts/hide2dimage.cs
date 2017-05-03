using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hide2dimage : MonoBehaviour {
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public Button yourButton;

    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        if (a != b)

        {
            b.SetActive(false);
        }
        if (a != c)

        {
            c.SetActive(false);
        }
        if (a != d)
        {
            d.SetActive(false);
        }
        


    }
}
