using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class coods : MonoBehaviour {
   public GodGoods god;
   public Button once;
   public luckypro proplus;

	// Use this for initialization
         void Awake()
    {
                //     options.resultCallback = ShowResult result;
    }
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {        
	}
    void lucky()
    {
        if (Advertisement.isReady() )
        {
            Advertisement.Show(null, new ShowOptions
            {
                //   pause = true,
                resultCallback = result =>
                {
                    if (result.ToString() == "Finished")
                    {
                        god.tmp = true;
                        god.times = 0;
                        once.interactable = false;
                    }
                }
            });
        }

    }
    void pro()
    {
        if (Advertisement.isReady() )
        {
            Advertisement.Show(null, new ShowOptions
            {
                //   pause = true,
                resultCallback = result =>
                {
                    if (result.ToString() == "Finished")
                    {
                        proplus.SendMessage("pluspiont");
                        once.interactable = false;
                    }
                }
            });
        }

    }
    void money()
    {
        if (Advertisement.isReady())
        {
            Advertisement.Show(null, new ShowOptions
            {
                //   pause = true,
                resultCallback = result =>
                {
                    if (result.ToString() == "Finished")
                    {
                        proplus.SendMessage("plusmoney");
                        once.interactable = false;
                    }
                }
            });
        }

    }
    void item()
    {
    }
}
