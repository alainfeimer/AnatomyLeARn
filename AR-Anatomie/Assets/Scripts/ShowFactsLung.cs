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
        facts.Add("Hier steht der erste Lungen Fakt");
        facts.Add("Hier steht der zweite Lungen Fakt");
        facts.Add("Hier steht der dritte Lungen Fakt");
        facts.Add("Hier steht der vierte Lungen Fakt");
        facts.Add("Hier steht der fünfte Lungen Fakt");

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