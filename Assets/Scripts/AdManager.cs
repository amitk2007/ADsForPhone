﻿using UnityEngine;
using System.Collections;
using admob;

public class AdManager : MonoBehaviour
{
    public static AdManager Instance { set; get; }

    public string bunnerId = "ca-app-pub-1819293788939652/2866953691";
    public string videoId = "ca-app-pub-1819293788939652/4343686897";

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        Admob.Instance().initAdmob(bunnerId, videoId);
        //Admob.Instance().setTesting(true);
        Admob.Instance().loadInterstitial();
    }

    public void ShowBanner()
    {
        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 0);
    }

    public void ShowVideo()
    {
        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
        }
        else
        {
            Admob.Instance().loadInterstitial();
        }
    }
}
