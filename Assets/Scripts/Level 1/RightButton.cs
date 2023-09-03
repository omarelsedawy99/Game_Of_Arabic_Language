using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    private int index;
    private GameObject Letter;

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
            index++;
            Letter = FindObject("Letter" + index.ToString());
            Letter.SetActive(true);
        }
    }
}
