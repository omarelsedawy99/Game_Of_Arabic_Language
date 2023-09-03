using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    private int index1;
    private GameObject Letter1;
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
    public void prevLetter()
    {
        for (int i = 1; i < 29; i++)
        {
            Letter1 = GameObject.Find("Letter" + i.ToString());
            if (Letter1 != null)
                index1 = i;
        }
        if (index1 != 1)
        {
            Letter1 = GameObject.Find("Letter" + index1.ToString());
            Letter1.SetActive(false);
            img1 = GameObject.Find("letter" + index1.ToString() + "-1");
            img1.SetActive(false);
            img2 = GameObject.Find("letter" + index1.ToString() + "-2");
            img2.SetActive(false);
            index1--;
            Letter1 = FindObject("Letter" + index1.ToString());
            Letter1.SetActive(true);
            img1 = FindObject("letter" + index1.ToString() + "-1");
            img1.SetActive(true);
            img2 = FindObject("letter" + index1.ToString() + "-2");
            img2.SetActive(true);
        }
    }
}
