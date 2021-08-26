using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNextFact : MonoBehaviour
{
    public GameObject Test;
    public List<string> facts = new List<string>();
    int count = 0;

    void Start()
    {
        facts.Add("Das Herz pumpt Blut durch Deinen Körper und versorgt die Zellen mit Sauerstoff");
        facts.Add("Das Herz eines Mannes wiegt ca. 300g. Das einer Frau ca. 250g");
        facts.Add("Das Herz pumpt bis zu 10.000 Liter Blut durch den Körper und schlägt ca. 100.000 Mal am Tag");
        facts.Add("Die erste erfolgreiche Herztransplantation wurde 1967 durchgeführt");
        facts.Add("Die Venen führen zum Herzen hin, die Aterien führen vom Herzen weg");

        count = 0;
        GameObject.Find("FactText").GetComponentInChildren<Text>().text = facts[count].ToString();
    }
    
    public void nextFact(string dir)
    {
        if(dir == "next")
        {
            count = count + 1;
            if(count == 5)
            {
                count = 0;
            }


        } else if (dir == "prev")
        {
            count = count -1;
            if(count == -1)
            {
                count = 4;
            }
        }

        GameObject.Find("FactText").GetComponentInChildren<Text>().text = facts[count].ToString();
    }
}
