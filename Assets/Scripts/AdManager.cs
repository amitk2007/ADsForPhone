using UnityEngine;
using System.Collections;
using admob;

public class AdManager : MonoBehaviour {

	public static AdManager Instance{ set; get;}
	public string BunnerID = "ca-app-pub-1819293788939652/2788058490";
	public string VidoeID = "ca-app-pub-1819293788939652/6380653291";
	// Use this for initialization
	private void Start () {

		Instance = this;
		DontDestroyOnLoad (gameObject);

		Admob.Instance ().initAdmob (BunnerID,VidoeID);
		Admob.Instance ().setTesting (true);
		Admob.Instance ().loadInterstitial ();

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
