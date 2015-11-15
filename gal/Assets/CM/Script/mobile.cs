using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mobile : MonoBehaviour {
        #if UNITY_IOS || UNITY_ANDROID || UNITY_WP8

	//1. First of all, we need a reference to hold an instance of UniWebView
	private UniWebView _webView;

    private string _errorMessage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void showmobile()
    {
        _webView = gameObject.AddComponent<UniWebView>();
        // _webView.OnReceivedMessage += OnReceivedMessage;
        _webView.OnLoadComplete += OnLoadComplete;
        int bottomInset = (int)(UniWebViewHelper.screenHeight * 0.1f);
        int top = (int)(UniWebViewHelper.screenHeight * 0.9f);
        int right = (int)(UniWebViewHelper.screenWidth * 0.3f);
        //_webView.OnWebViewShouldClose += OnWebViewShouldClose;
        // _webView.OnEvalJavaScriptFinished += OnEvalJavaScriptFinished;
        _webView.insets = new UniWebViewEdgeInsets(5, right, 5, right);
        _webView = GetComponent<UniWebView>();
        _webView.url = "https://www.google.co.jp/";
        _webView.Load();

        _errorMessage = null;

    }
      void OnLoadComplete(UniWebView webView, bool success, string errorMessage)
    {
        if (success)
        {
            webView.Show();
        }
        else
        {
            Debug.Log("Something wrong in webview loading: " + errorMessage);
            _errorMessage = errorMessage;
        }
    }
      void close()
      {
          _webView.Hide();

      }
#endif
}
