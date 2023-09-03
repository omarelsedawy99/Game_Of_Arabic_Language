using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    private int index;
    private GameObject Letter;
    private GameObject img1;
    private GameObject img2;

    private GameObject FindObject(string name)
    {
        GameObject[] objects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject obj in objects)
        {
            if (obj.name == name)
            {
                return obj.gameObject;
            }
        }
        return null;
    }
    public void nextLetter()
    {
        for (int i = 1; i < 29; i++)
        {
            Letter = GameObject.Find("Letter" + i.ToString());
            if (Letter != null)
                index = i;
        }

        if (index != 28)
        {
            Letter = GameObject.Find("Letter" + index.ToString());
            Letter.SetActive(false);
            img1 = GameObject.Find("letter" + index.ToString() + "-1");
            img1.SetActive(false);
            img2 = GameObject.Find("letter" + index.ToString() + "-2");
            img2.SetActive(false);
            index++;
            Letter = FindObject("Letter" + index.ToString());
            Letter.SetActive(true);
            img1 = FindObject("letter" + index.ToString() + "-1");
            img1.SetActive(true);
            img2 = FindObject("letter" + index.ToString() + "-2");
            img2.SetActive(true);
        }
    }
}
