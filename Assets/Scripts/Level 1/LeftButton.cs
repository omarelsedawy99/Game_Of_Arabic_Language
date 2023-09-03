using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    private int index1;
    private GameObject Letter1;

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
            index1--;
            Letter1 = FindObject("Letter" + index1.ToString());
            Letter1.SetActive(true);
        }
    }
}
