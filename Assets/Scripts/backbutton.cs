using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour {
    public int value;
     void OnMouseDown()
    {
         SceneManager.LoadScene("move");
          Debug.Log("Click");
        value = value + 1;
    }
    private void OnMouseEnter()
    {
        Debug.Log("Cursor is inside");
    }
    private void OnMouseExit()
    {
        Debug.Log("Cursor has left the cube");
    }

}
