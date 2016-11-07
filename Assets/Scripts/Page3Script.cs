using UnityEngine;
using System.Collections;

public class Page3Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Pgae1Script.bol = !Pgae1Script.bol;
			Application.LoadLevel ("page1");
	}
}
