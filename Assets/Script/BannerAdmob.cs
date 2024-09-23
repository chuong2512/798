using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerAdmob : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111"; //YOUR ADMOB BANNER ID HERE
#elif UNITY_IPHONE
            string adUnitId = "";
#else
        string adUnitId = "unexpected_platform";
#endif

    }
}
