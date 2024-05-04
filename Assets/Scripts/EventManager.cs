using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    SceneTransition sceneTransition;
    public Image image;
    private void Start()
    {
        sceneTransition = FindObjectOfType<SceneTransition>();
        sceneTransition.isEntered = true;
        sceneTransition.StartScreenTransition();
    }
}
