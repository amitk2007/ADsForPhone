using UnityEngine;
using System.Collections;
using admob;

public class Page2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
		if (Input.touches.Length>1) {
			Admob.Instance ().showInterstitial ();
			Application.LoadLevel ("VideoAdPage");
		}
	}
}
