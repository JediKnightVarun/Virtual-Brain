using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {
    public Renderer target = null;
    public Renderer target1 = null;
    public Renderer target2 = null;
    public Renderer target3 = null;
    public Renderer target4 = null;
    public Renderer target5 = null;
    public Renderer target7 = null;
    public Renderer target6 = null;

    public Color color1;

    // Use this for initialization
    void Start() {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {

            if (target != null)
            {



                //target.material.shader = Shader.Find("CB");

                target.material.SetColor("_Color", color1);
            }
            if (target1 != null)
            {



                //target.material.shader = Shader.Find("CB");

                target1.material.SetColor("_Color", color1);
            }
            if (target2 != null)
            {



                //target.material.shader = Shader.Find("CB");

                target2.material.SetColor("_Color", color1);
            }
            if (target3 != null)
            {



                //target.material.shader = Shader.Find("CB");

                target3.material.SetColor("_Color", color1);
            }
            if (target4 != null)
            {



                //target.material.shader = Shader.Find("CB");

                target4.material.SetColor("_Color", color1);
            }
            if (target5 != null)
            {



                //target.material.shader = Shader.Find("CB");

                target5.material.SetColor("_Color", color1);
            }
            if (target6 != null)
            {



                //target.material.shader = Shader.Find("CB");

                target6.material.SetColor("_Color", color1);
            }
            if (target7 != null)
            {



                //target.material.shader = Shader.Find("CB");

                target7.material.SetColor("_Color", color1);
            }
        }
    }
}
