using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AdManager.Instance.ShowBanner();
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void StartGame()
    {
        Application.LoadLevel("MainGame");
    }
}
