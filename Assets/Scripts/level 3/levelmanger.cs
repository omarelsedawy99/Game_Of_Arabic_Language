using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanger : MonoBehaviour
{
    private int index;
    private GameObject img;
    private GameObject option1;
    private GameObject option2;

    void Start()
    {
        for (int i = 2; i < 29; i++)
        {
            img = GameObject.Find("letter" + i.ToString() + "-1");
            img.SetActive(false);
            option1 = GameObject.Find("option" + i.ToString() + "-1");
            option1.SetActive(false);
            option2 = GameObject.Find("option" + i.ToString() + "-2");
            option2.SetActive(false);
            
        }
    }

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
            img = GameObject.Find("letter" + i.ToString() + "-1");
            if (img != null)
            {
                index = i;
            }
        }

        if (index != 28)
        {
            
            img = GameObject.Find("letter" + index.ToString() + "-1");
            img.SetActive(false);
            option1 = GameObject.Find("option" + index.ToString() + "-1");
            option1.SetActive(false);
            option2 = GameObject.Find("option" + index.ToString() + "-2");
            option2.SetActive(false);
            index++;
            img = FindObject("letter" + index.ToString() + "-1");
            img.SetActive(true);
            option1 = FindObject("option" + index.ToString() + "-1");
            option1.SetActive(true);
            option2 = FindObject("option" + index.ToString() + "-2");
            option2.SetActive(true);
        }
    }
}
