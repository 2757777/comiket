using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PutInBag : MonoBehaviour {
    public pluslist quantity;
    public playerbag bagwindow;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void send()
    {
        //鞄の中にボタンをつくる
      for( int n=1;n<=quantity.dakimac;n++){
          bagwindow.SendMessage("makedakima");
      }
      for (int n = 1; n <= quantity.tapec; n++)
      {
          bagwindow.SendMessage("maketape");
      }
      for (int n = 1; n <= quantity.goodsc; n++)
      {
          bagwindow.SendMessage("makegoods");
      }
      for (int n = 1; n <=quantity.booksc; n++)
      {
          bagwindow.SendMessage("makebooks");
      }

    }

}
