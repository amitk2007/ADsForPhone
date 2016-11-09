using UnityEngine;
using System.Collections;

public class CubePreloadre : MonoBehaviour {
    public static bool testads;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (this.transform.position== new Vector3(1,0,0))
        {
            testads = true;
            Application.LoadLevel("PreLoader");
        }
        if (this.transform.position == new Vector3(-1,0,0))
        {
            testads = false;
            Application.LoadLevel("PreLoader");
        }
    }
}
