using UnityEngine;
using System.Collections;
using admob;

public class Pgae1Script : MonoBehaviour {

	public static Admob ad;
	void initAdmob()
	{
		
		//  isAdmobInited = true;
		ad = Admob.Instance();
		ad.initAdmob("ca-app-pub-1819293788939652/2788058490", "ca-app-pub-1819293788939652/6380653291");
		//   ad.setTesting(true);
		Debug.Log("admob inited -------------");
		
	}
	// Use this for initialization
	void Start () {
		initAdmob();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
		Application.LoadLevel ("BunnerAdPage");
	}
}
