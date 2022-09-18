using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;


public class AdsManagerHub : MonoBehaviour
{
    private BannerView AdBanner;
    public static AdsManagerHub instance = new AdsManagerHub();
    private void Awake()
    {
        if(instance == null){
            instance = this;
        }
    }
    private void Start()
    {
        MobileAds.Initialize(InitializationStatus => {});

       // this.RequestBanner();
    }
    public void RequestBanner()
    {
        string unitId = "ca-app-pub-3940256099942544/6300978111";
        this.AdBanner = new BannerView(unitId, AdSize.Banner , AdPosition.Top);

          // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.AdBanner.LoadAd(request);
    }
 public void Destroy()
 {
    AdBanner.Destroy();
 }
}

