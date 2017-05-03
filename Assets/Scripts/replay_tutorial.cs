using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class replay_tutorial : MonoBehaviour {
    public Button yourButton;
    public AudioSource audio;
    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void TaskOnClick() {
        audio.Play();
		
	}
}
