using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class homepro : MonoBehaviour {
    public playerproperty pro;
    Text showtext;
    public Button speed, knowledge, analytic, fortitude, sociable;
	// Use this for initialization
	void Start () {
        showtext = GetComponent<Text>();
        showtext.text = "速度        " + pro.speed +
                        "\n\n知識        " + pro.knowledge +
                        "\n\n分析力    " + pro.analytic +
                        "\n\n忍耐力    " + pro.fortitude +
                        "\n\n社交力    " + pro.sociable+
                        "\n\n分配点    " + pro.distribution;
        if (pro.distribution > 0)
        {
            speed.interactable = true;
            knowledge.interactable = true;
            analytic.interactable = true;
            fortitude.interactable = true;
            sociable.interactable = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
	}
    void refresh()
    {
        showtext.text = "速度        " + (int)pro.speed +
                "\n\n知識        " + (int)pro.knowledge +
                "\n\n分析力    " + (int)pro.analytic +
                "\n\n忍耐力    " + (int)pro.fortitude +
                "\n\n社交力    " + (int)pro.sociable +
                "\n\n分配点    " + (int)pro.distribution;
        if (pro.distribution > 0)
        {
            speed.interactable = true;
            knowledge.interactable = true;
            analytic.interactable = true;
            fortitude .interactable = true;
            sociable.interactable = true;
        }
        if (pro.distribution == 0)
        {
            speed.interactable = false;
            knowledge.interactable = false;
            analytic.interactable = false;
            fortitude.interactable = false;
            sociable.interactable = false;

        }
    }
    void speedup()
    {
        pro.speed++;
        pro.distribution--;
        refresh();
    }
    void knowledgeup()
    {
        pro.knowledge++;
        pro.distribution--;
        refresh();
    }
    void analyticup()
    {
        pro.analytic++;
        pro.distribution--;
        refresh();
    }

    void fortitudeup()
    {
        pro.fortitude++;
        pro.distribution--;
         refresh();
     }

     void sociableup()  
     {
         pro.sociable++;
         pro.distribution--;
         refresh();
     }
}
