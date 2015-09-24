using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class GoogleAdVideo : MonoBehaviour {
	
	InterstitialAd interstitial;
	
	private void Start(){
		RequestInterstitial();
	}
	
	private void RequestInterstitial()
	{
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-1663284785812885/6627977457";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "unexpected_platform";
		#endif
		
		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd(adUnitId);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		if (!interstitial.IsLoaded ()) {
			interstitial.LoadAd(request);
		}
	}
	
	public void ShowVideo(){
		if (interstitial.IsLoaded ()) {
			interstitial.Show ();
		}
	}
}
