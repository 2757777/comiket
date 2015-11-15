using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BagButtonProperty : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public string Circlename,kind;
    public int value,level;
    public float sale;
    bool col;
    float tem;
    salemassage salemassage;
	// Use this for initialization
	void Start () {
        if (name == "dakima(Clone)")
        {
            Circlename = GameObject.Find("list").GetComponentInChildren<pluslist>().Circlename;
            value = GameObject.Find("list").GetComponentInChildren<pluslist>().dakimam;
            level = GameObject.Find("list").GetComponentInChildren<pluslist>().desklevel / 3;
            sale = GameObject.Find("list").GetComponentInChildren<pluslist>().dakimasale;
            kind = "抱き枕カバー";
        }
        if (name == "tape(Clone)")
        {
            Circlename = GameObject.Find("list").GetComponentInChildren<pluslist>().Circlename;
            value = GameObject.Find("list").GetComponentInChildren<pluslist>().tapem;
            level = GameObject.Find("list").GetComponentInChildren<pluslist>().desklevel / 5;
            sale = GameObject.Find("list").GetComponentInChildren<pluslist>().tapesale;
            kind = "タペストリー";
        }
        if (name == "goods(Clone)")
        {
            Circlename = GameObject.Find("list").GetComponentInChildren<pluslist>().Circlename;
            value = GameObject.Find("list").GetComponentInChildren<pluslist>().goodsm;
            level=GameObject.Find("list").GetComponentInChildren<pluslist>().desklevel / 7;
            sale = GameObject.Find("list").GetComponentInChildren<pluslist>().goodssale;
            kind = "グッズセット";

        }
        if (name == "books(Clone)")
        {
            Circlename = GameObject.Find("list").GetComponentInChildren<pluslist>().Circlename;
            value = GameObject.Find("list").GetComponentInChildren<pluslist>().booksm;
            level = GameObject.Find("list").GetComponentInChildren<pluslist>().desklevel / 9;
            sale = GameObject.Find("list").GetComponentInChildren<pluslist>().booksale;
            kind = "新刊";
        }
        GetComponentInChildren<Text>().text =
                                      value + "円\n" +
                                      level + "★";



}

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponentInChildren<Text>().text = Circlename;
        salemassage = GameObject.Find("salemassage").GetComponent<salemassage>();
        salemassage.Circlename = Circlename;
        salemassage.kind = kind;
        salemassage.salemoney = (int)sale;
        salemassage.goods=this.gameObject;
        salemassage.SendMessage("show");

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        GetComponentInChildren<Text>().text =
                                      value + "円\n" +
                                      level + "★";
    }

	// Update is called once per frame
	void Update () {
	}

}
