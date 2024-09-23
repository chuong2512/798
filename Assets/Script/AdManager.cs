using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AdManager : MonoBehaviour
{
    //ADMOB APP ID
    public string appId = "ca-app-pub-3940256099942544~3347511713"; //your app ID here


    // Start is called before the first frame update
    void Start()
    {
        RequestInterstitial();
    }


    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string adUnitId = "";
#else
        string adUnitId = "unexpected_platform";
#endif
    }


    public void ShowInterstitialAd()

    {
    }

    private void RequestRewardBasedVideo()
    {
#if UNITY_ANDROID
            string adUnitId = "UNUSED";
#elif UNITY_IPHONE
            string adUnitId = "";
#else
        string adUnitId = "unexpected_platform";
#endif
    }

    public void ShowVideoAd()
    {
    }
}