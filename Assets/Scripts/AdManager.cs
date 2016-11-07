using UnityEngine;
using System.Collections;
using admob;

public class AdManager : MonoBehaviour {

	public static AdManager Instance{ set; get;}
	public string BunnerID = "ca-app-pub-1819293788939652/2788058490";
	public string VidoeID = "ca-app-pub-1819293788939652/6380653291";

	bool AdsIsTest = true;
	// Use this for initialization
	private void Start () {

		Instance = this;
		DontDestroyOnLoad (gameObject);

		Admob.Instance ().initAdmob (BunnerID,VidoeID);
		if (AdsIsTest) {
			Admob.Instance ().setTesting (true);
		}
		Admob.Instance ().loadInterstitial ();

	}

	void OnGUI(){
		if (GUI.Button (new Rect (0, 0, 200, 200), AdsIsTest.ToString())) {
			AdsIsTest = !AdsIsTest;
		}
	}

	public void ShowBunner()
	{
		Admob.Instance ().showBannerRelative (AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
	}


	public void ShowVidoe()
	{
		if (Admob.Instance().isInterstitialReady()) {
			Admob.Instance().showInterstitial();
		}
	}
}
