using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFactsLung : MonoBehaviour
{
    public List<string> facts = new List<string>();
    int count = 0;

    void Start()
    {
        facts.Add("Die Lunge besteht aus zwei Lungenflügeln. Sie wiegt ca. 1.3 Kilogramm");
        facts.Add("Pro Tag atmet man ca. 20.000 Mal ein und aus");
        facts.Add("In der Lunge befinden sich ca. 400 Millionen Lungenbläschen");
        facts.Add("Beim Einatmen vergrößert sich das Volumen der Lunge");
        facts.Add("Raucher benötigen die doppelte Menge an Sauerstoff wie Nichtraucher");

        count = 0;
        GameObject.Find("LungFacts").GetComponentInChildren<Text>().text = facts[count].ToString();
    }

    public void nextFact(string dir)
    {
        if (dir == "next")
        {
            count = count + 1;
            if (count == 5)
            {
                count = 0;
            }


        }
        else if (dir == "prev")
        {
            count = count - 1;
            if (count == -1)
            {
                count = 4;
            }
        }

        GameObject.Find("LungFacts").GetComponentInChildren<Text>().text = facts[count].ToString();
    }
}