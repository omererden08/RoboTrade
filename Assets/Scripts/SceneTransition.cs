using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public Color color;
    public Image image;
    private IEnumerator screentransition;
    public bool isEntered;
    public static SceneTransition instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    private void Start()
    {
        color = image.color;
        isEntered = true;
        StartScreenTransition();
    }
    public void StartScreenTransition()
    {
        if (isEntered == false)
        {
            color.a = 0;
        }
        screentransition = SceneTranslator();
        StartCoroutine(screentransition);
        Debug.Log("356");
    }

    IEnumerator SceneTranslator()
    {
            
        while (true) 
        { 
            yield return new WaitForFixedUpdate();
            if (isEntered == true)
            {
                color.a -= 0.5f * Time.fixedDeltaTime;
                image.color = color;
                Debug.Log("123");
            }
            else if (isEntered == false)
            {
                color.a += 0.5f * Time.fixedDeltaTime;
                image.color = color;
                Debug.Log("456");
            }
        }
    }
}
