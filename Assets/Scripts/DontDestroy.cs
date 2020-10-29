using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public Image FadeImg;
    AudioSource a;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        a = GetComponent<AudioSource>();
        a.Play();

        if (GameObject.FindGameObjectsWithTag("AudioSource").Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

            FadeImg = GameObject.Find("FadeImage").GetComponent<Image>();
            a.volume = 0.6f - FadeImg.color.a;

    }
}
