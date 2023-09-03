using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    private int index2;
    private GameObject Letter2;

    void Start()
    {
        for (int i = 2; i < 29; i++)
        {
            Letter2 = GameObject.Find("Letter" + i.ToString());
            Letter2.SetActive(false);
        }
    }

    public void playSound()
    {
        for (int i = 1; i < 29; i++)
        {
            Letter2 = GameObject.Find("Letter" + i.ToString());
            if (Letter2 != null)
                index2 = i;
        }
        Letter2 = GameObject.Find("Letter" + index2.ToString());
        var sound = Letter2.GetComponent<AudioSource>();
        sound.Play();
    }
}
